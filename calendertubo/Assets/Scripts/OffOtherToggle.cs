using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OffOtherToggle : MonoBehaviour
{
    public List<GameObject> otherToggle = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OtherOff()
    {
        for(int i = 0;i < 2;i++)
        {
            otherToggle[i].GetComponent<Toggle>().isOn = false;
        }
    }
}
