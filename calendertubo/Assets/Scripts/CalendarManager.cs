using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class CalendarManager : MonoBehaviour
{
    public GameObject frame;
    public GameObject calendarDate;
    public GameObject dayPanel;
    public List<GameObject> dayPanels = new List<GameObject>();

    private Text calendarDateText = null;
    private Image[] dayPanelColor = new Image[42];
    private Text[] dayText = new Text[42];
    private Text[] dayplans = new Text[42];

    private DateTime firstDay = DateTime.MinValue;
    private DateTime nextMonth = DateTime.MinValue;
    private DateTime firstPoint = DateTime.MinValue;

    public FutureManager FM;
    public NowManager NM;
    public ChoiceManager CM;
    public GameManager GM;

    public int month = 1;
    public GameObject monthText;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        GetTheDate();

        // calendarDateText = calendarDate.GetComponent<Text>();
        // calendarDateText.text = firstDay.ToString("2022年12月");

        CreateDayPanel();
    }

    // Update is called once per frame
    void Update()
    {
        monthText.GetComponent<Text>().text = month.ToString();
    }

    private void CreateDayPanel()
    {
        for (int i = 2; i < 32; i++)
        {
            GameObject createPanel = Instantiate(dayPanel);
            createPanel.transform.SetParent(frame.transform, false);
            dayPanelColor[i] = createPanel.GetComponent<Image>();
            dayText[i] = createPanel.transform.GetChild(0).GetComponent<Text>();
            dayText[i].text = i.ToString();
            if(SceneManager.GetActiveScene().name == "Calendar_Now")
            {
                dayplans[i] = createPanel.transform.GetChild(1).GetComponent<Text>();
                dayplans[i].text = new choice(GM.user1.ending, 0).line.Insert(6, "\n");
            }
            dayPanels.Add(createPanel);
        }
    }

    private void DeleteDayPanel()
    {
        for(int i = 0;i < dayPanels.Count;i++)
        {
            Destroy(dayPanels[i].gameObject);
        }
        dayPanels = new List<GameObject>();
    }

    public void GoNextMonth()
    {
        if(month != 12)
        {
            DeleteDayPanel();
            CreateDayPanel();
            if (SceneManager.GetActiveScene().name == "Calendar_Future")
            {
                FM.GetComponent<FutureManager>().setLine();
            }
            if (SceneManager.GetActiveScene().name == "Calendar_Now")
            {
                CM.GetComponent<ChoiceManager>().checkChoices();
                NM.GetComponent<NowManager>().CreateChoiceAtMonth();
                CM.GetComponent<ChoiceManager>().showChoices();
            }
            month++;
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "Calendar_Now")
            {
                GoToFuture();
            }
        }
    }

    public GameObject DarkPanel;
    public void GoToFuture()
    {
        if (month == 12)
        {
            DarkPanel.GetComponent<SceneChange_DarkTurn>().nextScene = 2;
            DarkPanel.GetComponent<SceneChange_DarkTurn>().startTurn_in();
        }
    }

    private void GetTheDate(){
        DateTime temp = DateTime.Now.Date;
        firstDay = new DateTime(temp.Year, temp.Month,1);
        nextMonth = firstDay.AddMonths(1);

    }
}
