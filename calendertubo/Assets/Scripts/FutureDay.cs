using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FutureDay : MonoBehaviour
{
    public bool tachable = false;
    public string line = "";
    public GameObject frontPanel;
    public GameObject frontText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set(string l)
    {
        tachable = true;
        line = l;
        for(int i = 0; i < line.Length; i++)
        {
            if(i % 18 == 0)
            {
                line = line.Insert(i, "\n");
                Debug.Log(line);
            }
        }
        this.GetComponent<Image>().color = new Color(1, 1, 0, 1);
    }

    public void printLine()
    {
        if(tachable)
        {
            frontPanel.GetComponent<Darken>().StartDarken();
            frontText.GetComponent<Text>().text = line;
        }
    }
}
