using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowManager : MonoBehaviour
{
    public ChoiceManager ChoiceM;
    public CalendarManager CalenderM;
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        ChoiceM = GameObject.Find("ChoiceManager").GetComponent<ChoiceManager>();
        CalenderM = GameObject.Find("Canvas").GetComponent<CalendarManager>();
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        ChoiceM.createChoices("muscle", "occult", "knowledge", 1);
        ChoiceM.showChoices();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateChoiceAtMonth()
    {
        if(CalenderM.month == 1)
        {
            ChoiceM.createChoices("friendship", "muscle", "knowledge", 1);
        }
        else if(CalenderM.month == 2)
        {
            ChoiceM.createChoices("friendship", "occult", "knowledge", 1);
        }
        else if(CalenderM.month == 3)
        {
            ChoiceM.createChoices("friendship", "muscle", "knowledge", 1);
        }
        else if (CalenderM.month == 4)
        {
            ChoiceM.createChoices("friendship", "fail", "occult", 1);
        }
        else if (CalenderM.month == 5)
        {
            ChoiceM.createChoices("knowledge", "muscle", "occult", 1);
        }
        else if (CalenderM.month == 6)
        {
            ChoiceM.createChoices("knowledge", "friendship", "occult", 1);
        }
        else if (CalenderM.month == 7)
        {
            ChoiceM.createChoices("knowledge", "friendship", "muscle", 1);
        }
        else if (CalenderM.month == 8)
        {
            ChoiceM.createChoices("occult", "friendship", "muscle", 1);
        }
        else if (CalenderM.month == 9)
        {
            ChoiceM.createChoices("occult", "knowledge", "muscle", 1);
        }
        else if (CalenderM.month == 10)
        {
            ChoiceM.createChoices("occult", "knowledge", "friendship", 1);
        }
        else if (CalenderM.month == 11)
        {
            ChoiceM.createChoices("muscle", "knowledge", "friendship", 1);
        }
        else if (CalenderM.month == 12)
        {
            ChoiceM.createChoices("muscle", "occult", "fail", 1);
        }
    }
}
