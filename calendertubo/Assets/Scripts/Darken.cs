using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Darken : MonoBehaviour
{
    public int mode = 0;//0:ニュートラル、1:暗くする、2:元に戻す
    public float alfa;
    public float speed;
    public float NeutralTime = 0;
    public GameObject childText;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 0)
        {
            NeutralTime += Time.deltaTime;

            if (NeutralTime >= childText.GetComponent<Text>().text.Length / 5)
            {
                mode = 2;
            }
        }
        else if (mode == 1)
        {
            NeutralTime = 0;
            if (alfa <= 0.7f)
            {
                alfa += speed * Time.deltaTime;
            }
            else
            {
                mode = 0;
            }
        }
        else if (mode == 2)
        {
            NeutralTime = 0;
            if (alfa >= 0)
            {
                alfa -= speed * Time.deltaTime;
            }
            else
            {
                this.gameObject.SetActive(false);
                mode = 0;
            }
        }

        this.GetComponent<Image>().color = new Color(0, 0, 0, alfa);
        childText.GetComponent<Text>().color = new Color(1, 1, 1, alfa);
    }

    public void StartDarken()
    {
        this.gameObject.SetActive(true);
        mode = 1;
    }

    public void EndDarken()
    {
        mode = 2;
    }
}
