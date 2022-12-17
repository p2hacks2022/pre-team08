using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange_DarkTurn : MonoBehaviour
{
    Image image;
    public int mode = 0;//0:ニュートラル、1:暗転に入る、2:暗転から抜ける
    public float alfa;
    public float speed;
    public RectTransform rt;
    public int nextScene;
    // Start is called before the first frame update
    void Start()
    {
        rt = this.GetComponent<RectTransform>();
        image = this.GetComponent<Image>();
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(mode == 0)
        {
            
        }
        if (mode == 1)
        {
            turn_in();
        }
        if (mode == 2)
        {
            turn_out();
        }
        image.color = new Color(0, 0, 0, alfa);
    }

    void turn_in()
    {
        if(alfa <= 1)
        {
            alfa += speed * Time.deltaTime;
        }
        else
        {
            GotoNextScene();
            this.gameObject.SetActive(false);
            mode = 0;
        }
    }

    void turn_out()
    {
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

    public void startTurn_in()
    {
        this.gameObject.SetActive(true);
        mode = 1;
    }

    public void startTurn_out()
    {
        this.gameObject.SetActive(true);
        mode = 2;
    }

    void GotoNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
