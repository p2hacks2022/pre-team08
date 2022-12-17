using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class choice//選択肢一つ一つを管理するクラス
{
    public string relatedStatus;
    public string line;
    public int valueChange;

    public choice(string status, int value)
    {
        relatedStatus = status;
        valueChange = value;
        int rand = UnityEngine.Random.Range(1, 101);

        if (status == "knowledge")
        {
            if (rand <= 14)
            {
                line = "有名な弁護士の講演を聞きに行く";
            }
            else if (rand <= 28)
            {
                line = "図書館に行く";
            }
            else if (rand <= 42)
            {
                line = "学校に登校する";
            }
            else if (rand <= 56)
            {
                line = "本屋を見に行く";
            }
            else if (rand <= 70)
            {
                line = "参考書を買いに行く";
            }
            else if (rand <= 84)
            {
                line = "司法資格の勉強をする";
            }
            else
            {
                line = "勉強して過ごす";
            }
        }
        if (status == "friendship")
        {
            if (rand <= 14)
            {
                line = "友達とゲームセンターに行く";
            }
            else if (rand <= 28)
            {
                line = "友達とキャンプに行く";
            }
            else if (rand <= 42)
            {
                line = "友達と家でゲームをする";
            }
            else if (rand <= 56)
            {
                line = "友達と映画を見に行く";
            }
            else if (rand <= 70)
            {
                line = "友達に最近読んだ本をおすすめする";
            }
            else if (rand <= 84)
            {
                line = "友達とディナーに行く";
            }
            else
            {
                line = "友達と遊びに行く";
            }
        }
        if (status == "SNS")
        {
            if (rand <= 14)
            {
                line = "ネットのつぶやきを見て過ごす";
            }
            else if (rand <= 28)
            {
                line = "ネット配信をする";
            }
            else if (rand <= 42)
            {
                line = "ネットで雑談配信をする";
            }
            else if (rand <= 56)
            {
                line = "ネットでゲーム配信をする";
            }
            else if (rand <= 70)
            {
                line = "動画を作成する";
            }
            else if (rand <= 84)
            {
                line = "動画についたコメントをチェックする";
            }
            else
            {
                line = "動画配信を見て過ごす";
            }
        }
        if (status == "environment")
        {
            if (rand <= 14)
            {
                line = "外に出てゴミ拾いをする";
            }
            else if (rand <= 28)
            {
                line = "プラスチックゴミをリサイクルに出す";
            }
            else if (rand <= 42)
            {
                line = "庭で園芸をする";
            }
            else if (rand <= 56)
            {
                line = "庭の世話をする";
            }
            else if (rand <= 70)
            {
                line = "ゴミ出しを忘れない";
            }
            else if (rand <= 84)
            {
                line = "生ゴミをつかって肥料を作ってみる";
            }
            else
            {
                line = "部屋を掃除する";
            }
        }
        if (status == "muscle")
        {
            if (rand <= 14)
            {
                line = "だが筋トレをする";
            }
            else if (rand <= 28)
            {
                line = "しかし筋トレをする";
            }
            else if (rand <= 42)
            {
                line = "諦めずに筋トレをする";
            }
            else if (rand <= 56)
            {
                line = "筋トレをする(天上天下)";
            }
            else if (rand <= 70)
            {
                line = "筋トレをする(唯我独尊)";
            }
            else if (rand <= 84)
            {
                line = "筋トレをする(強靭無敵最強)";
            }
            else
            {
                line = "筋トレをする";
            }
        }
        if (status == "occult")
        {
            if (rand <= 14)
            {
                line = "UMAの本の続きを読む";
            }
            else if (rand <= 28)
            {
                line = "陰謀論についての本を読む";
            }
            else if (rand <= 42)
            {
                line = "陰謀論についての本の続きを読む";
            }
            else if (rand <= 56)
            {
                line = "幽霊の記事を探す";
            }
            else if (rand <= 70)
            {
                line = "エイリアンの記事を探す";
            }
            else if (rand <= 84)
            {
                line = "UMAの記事を探す";
            }
            else
            {
                line = "UMAの本を読む";
            }
        }
        if (status == "fail")
        {
            if (rand <= 14)
            {
                line = "ベッドから出ずに過ごす";
            }
            else if (rand <= 28)
            {
                line = "一日中ゲームをして過ごす";
            }
            else if (rand <= 42)
            {
                line = "ぼーっと過ごす";
            }
            else if (rand <= 56)
            {
                line = "お菓子をぼりぼりして過ごす";
            }
            else if (rand <= 70)
            {
                line = "外に出て日向ぼっこをする";
            }
            else if (rand <= 84)
            {
                line = "一日中寝て過ごす";
            }
            else
            {
                line = "だらだらする";
            }
        }
    }
}

public class ChoiceManager : MonoBehaviour
{
    public List<choice> choices = new List<choice>();
    public List<GameObject> checkboxes = new List<GameObject>();
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createChoices(string status1,string status2,string status3,int value)//選択肢を再設定
    {
        choices.Clear();
        choices.Add(new choice(status1, value));
        choices.Add(new choice(status2, value));
        choices.Add(new choice(status3, value));
    }

    public void showChoices()
    {
        for (int i = 0; i < checkboxes.Count; i++)
        {
            checkboxes[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = choices[i].line;
            checkboxes[i].GetComponent<Toggle>().isOn = false;
        }
    }

    public void checkChoices()
    {
        for(int i = 0; i < checkboxes.Count;i++)
        {
            if(checkboxes[i].GetComponent<Toggle>().isOn)
            {
                GM.user1.IncreaseStatus(choices[i].relatedStatus,1);
                break;
            }
        }
        GM.user1.checkEnding();
        Debug.Log(GM.user1.ending);
    }
}
