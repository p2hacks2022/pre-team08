using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showFutureYear : MonoBehaviour
{
    public GameManager GM;
    public int future_year;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GM.user1.ending == "knowledge")
        {
            future_year = 2026;
        }
        if (GM.user1.ending == "occult")
        {
            future_year = 2072;
        }
        if (GM.user1.ending == "friendship")
        {
            future_year = 2067;
        }
        if (GM.user1.ending == "muscle")
        {
            future_year = 2122;
        }
        this.GetComponent<Text>().text = future_year.ToString();
    }
}
