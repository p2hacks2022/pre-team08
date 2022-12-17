using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interest : MonoBehaviour
{
    public GameManager GM;
    string interest;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        interest = GM.user1.ending;

        if(interest == "friendship")
        {
            this.GetComponent<Text>().text = "交友";
        }
        if(interest == "environment")
        {
            this.GetComponent<Text>().text = "環境";
        }
        if (interest == "occult")
        {
            this.GetComponent<Text>().text = "怪異";
        }
        if (interest == "muscle")
        {
            this.GetComponent<Text>().text = "筋肉";
        }
        if (interest == "knowledge")
        {
            this.GetComponent<Text>().text = "勉強";
        }
        if (interest == "fail")
        {
            this.GetComponent<Text>().text = "なし";
        }
    }
}
