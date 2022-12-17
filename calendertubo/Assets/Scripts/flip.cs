using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flip : MonoBehaviour
{
    public GameObject screen;
    public RectTransform rt;
    public float scaleY;
    public float positionY;
    public bool isFlip = false;
    public bool isFlipBack = false;
    // Start is called before the first frame update
    void Start()
    {
        rt = screen.GetComponent<RectTransform>();
        scaleY = screen.transform.localScale.y;
        positionY = rt.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlip == true)
        {
            flipScreen();
        }
        if (isFlipBack == true)
        {
            flipBack();
        }
        if (scaleY != screen.transform.localScale.y)
        {
            screen.transform.localScale = new Vector3(1, scaleY, 1);
            rt.localPosition = new Vector3(0, positionY, 0);
        }
    }

    void flipScreen()
    {
        if(scaleY >= 0.0001f)
        {
            scaleY -= scaleY * Time.deltaTime * 10;
            positionY += (300 - positionY) * Time.deltaTime * 10;
        }
        else
        {
            isFlip = false;
        }
    }

    public void flipStart()
    {
        isFlip = true;
        isFlipBack = false;
    }

    void flipBack()
    {
        if (scaleY <= 0.99f)
        {
            scaleY += (1 - scaleY) * Time.deltaTime * 10;
            positionY -= positionY * Time.deltaTime * 10;
        }
        else
        {
            isFlipBack = false;
        }
    }

    public void flipBackStart()
    {
        isFlipBack = true;
        isFlip = false;
    }
}
