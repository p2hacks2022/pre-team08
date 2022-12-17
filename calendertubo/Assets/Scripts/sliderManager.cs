using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderManager : MonoBehaviour
{
    public List<GameObject> sliders = new List<GameObject>();
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
         for(int i = 0;i < 6;i++)
        {
            sliders[i].GetComponent<Slider>().value = GM.user1.statusList[i].statusCount;
        }
    }
}
