using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setUserName : MonoBehaviour
{
    InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        inputField = this.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sendUserName()
    {
        //InputFieldからテキスト情報を取得する
        string name = inputField.text;
        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        gm.MakeUser(name);
    }
}
