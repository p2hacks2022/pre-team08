using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class status//知識とか環境とかのステータス一つ一つを管理するクラス
{
    public string statusName;//ステータスの名前（知識、環境など）
    public int statusCount;//ステータスの数値（どの程度育っているのか）

    public status(string name)
    {
        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);
        statusName = name;
        statusCount = Random.Range(0,3);
    }
}

public class user//ユーザーネームとステータスを持っているユーザーそのもののクラス
{
    public string userName;//ユーザーの名前。余裕があれば、タイトル画面で変更できるようにしたい
    public List<status> statusList = new List<status>();//各ステータスを配列に格納
    public string ending = "";
    
    public user(string name)
    {
        userName = name;
        statusList.Add(new status("knowledge"));
        statusList.Add(new status("friendship"));
        statusList.Add(new status("SNS"));
        statusList.Add(new status("environment"));
        statusList.Add(new status("muscle"));
        statusList.Add(new status("occult"));
    }

    public void IncreaseStatus(string statusName,int number)//第一引数にステータスの名前、第二引数にどの程度値を増やすかを入れると、そのステータスが成長する。
    {
        for (int i = 0; i < statusList.Count; i++)
        {
            if(statusList[i].statusName == statusName)
            {
                statusList[i].statusCount += number;
                break;
            }
        }
    }

    public void DecreaseStatus(string statusName, int number)//第一引数にステータスの名前、第二引数にどの程度値を減らすかを入れると、そのステータスが減退する。
    {
        for (int i = 0; i < statusList.Count; i++)
        {
            if (statusList[i].statusName == statusName)
            {
                statusList[i].statusCount -= number;
                break;
            }
        }
    }

    public void checkEnding()//この関数を呼んだ時点のエンディングがどのステータスのものかをチェックする。これをやらないとエンディングがちゃんと決まらない。
    {
        int max = 0;
        for (int i = 0; i < statusList.Count; i++)
        {
            if (max < statusList[i].statusCount)
            {
                max = statusList[i].statusCount;
                ending = statusList[i].statusName;
            }
            else if (max == statusList[i].statusCount)
            {
                if(Random.Range(1,101) <= 50)
                {
                    ending = statusList[i].statusName;
                }
            }
        }
        if(max <= 4)
        {
            ending = "fail";
        }
    }
}

public class GameManager : MonoBehaviour
{
    public user user1;//ユーザーの仮インスタンス
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
        //MakeUserTest();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MakeUserTest()
    {
        if (user1 == null)
        {
            user1 = new user("ユーザー１");//ユーザーの仮インスタンス
        }

        Debug.Log(user1.userName);
        for (int i = 0; i < user1.statusList.Count; i++)
        {
            Debug.Log(user1.statusList[i].statusName);
            Debug.Log(user1.statusList[i].statusCount);
        }
        user1.IncreaseStatus("knowledge", 0);
        user1.checkEnding();
        Debug.Log(user1.ending);
    }

    public void MakeUser(string userName)
    {
        user1 = new user(userName);//ユーザーの仮インスタンス
        Debug.Log(user1.userName);
        for (int i = 0; i < user1.statusList.Count; i++)
        {
            Debug.Log(user1.statusList[i].statusName);
            Debug.Log(user1.statusList[i].statusCount);
        }
        user1.IncreaseStatus("knowledge", 0);
        user1.checkEnding();
        Debug.Log(user1.ending);
    }
}
