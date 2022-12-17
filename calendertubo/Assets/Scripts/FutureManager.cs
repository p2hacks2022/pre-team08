using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending
{
    public string ending_status;
    public List<string> lines = new List<string>();

    public Ending(string status)
    {
        ending_status = status;
        if(status == "friendship")
        {
            lines.Add("Aが遊びに来た。今日はなつかしいゲームを遊んだ。");
            lines.Add("友達がたくさん遊びに来た。今日は家で飲む約束をしていた。");
            lines.Add("今日はAが遊びに来た。最近仕事がうまく行っているみたいだ。");
            lines.Add("今日はBが遊びに来た。Bは今自宅の庭の花を植え替えようと思っているらしい。");
            lines.Add("今日はCが遊びに来た。Cは若い頃からの夢だったらしい自分の家を買ったという。");
            lines.Add("今日はAとBとCと自分で映画を見に行った。");
            lines.Add("今日、Aの病気が発覚した。入院しなければならないらしい。");
            lines.Add("Aが入院した。詳しい検査を受けている。心配だ。");
            lines.Add("BとCから連絡が来た。Aのことを聞いたそうだ。");
            lines.Add("今日はずっと一人だった。");
            lines.Add("今日はBが家に来た。Aがいなくて寂しいと話をした。");
            lines.Add("今日、Aに会いに行ってきた。おっさんになっても手術は怖いなと、うつろな笑みを浮かべていた。");
            lines.Add("BとCにAの手術の話をした。２人とも心から心配していた。");
            lines.Add("BとCと３人で、Aに会いに行ってきた。Aは手術に対する勇気がでないと、真面目な顔で言っていた。");
            lines.Add("Cから連絡が来た。Aを応援してやりたいという。");
            lines.Add("Bに、Aを応援したい旨を伝えた。３人でメッセージカードを作ることになった。");
            lines.Add("BとCと３人で、Aに会いに行ってきた。Aにできる限りの応援をしてきた。");
            lines.Add("Aから連絡が来た。ついに手術らしい。自分らの応援に応えると言ったその声は、とても明るかった。");
            lines.Add("Aから連絡が来た。手術は無事成功したらしい。自分のことのように嬉しい。");
            lines.Add("Aはまだ退院できないようなので、BとCとお見舞いしてきた。若干やつれていたが、元気を取り戻しているようだった。");
            lines.Add("Aが退院した。今日は家で過ごしたいらしいので、近々家に行ってやろう。");
            lines.Add("BとCと３人でAの家に行ってきた。なつかしいゲームをやった。");
            lines.Add("Aから連絡がきた。勇気をもって手術に臨めてのは、自分たち友達のおかげなのだという。");
            lines.Add("Aのほうはだいぶ落ち着いたようで、今は普段通りの生活ができているという。Aからの連絡にある通り、友達も力は偉大だと思う。自分も友達に助けられて「今」を生きている。これからも、このかけがえのない友人たちを大切に、「未来」を生きていこう。");
        }
        if(status == "knowledge")
        {
            lines.Add("今日は司法試験に受かるために勉強をした。");
            lines.Add("今日も司法試験の勉強。苦しいが、絶対に受かってやる。");
            lines.Add("今日は少し休んでしまった。毎日何時間も勉強だ。１日くらい大丈夫だろう。");
            lines.Add("今日はわからない問題が多くて、精神的に辛かった。頑張らなければ。");
            lines.Add("母さんから電話がかかってきた。りんごを送ってくれるらしい。応援してくれる家族のためにも、弁護士になる。");
            lines.Add("今日も勉強だ。今日は少し調子が良かった。このペースで続けたい。");
            lines.Add("今日も勉強だ。あと少しで模試がある。特に頑張りどころだ。");
            lines.Add("今日も勉強。すこし予定通りできていない。不安だ。");
            lines.Add("もうすぐ模試だ。スケジュールは破綻。やる気がどうしてもでない。");
            lines.Add("今日は模擬試験を受けた。感触は良くない。");
            lines.Add("模試の結果が気になって仕方がない。不安のまま勉強をした。");
            lines.Add("模試の結果が返ってきた。散々な結果だった。やる気が萎えてしまった。");
            lines.Add("机に座って、ペンを持って、参考書の問題を解く。間違いがやけに多く感じる。");
            lines.Add("勉強に全く身が入らない。今日も一日中ぼーっとしていた。");
            lines.Add("机に向かって座った。けど座っただけで１日が終わってしまった。もう何をしても無駄なんじゃないかと思う。");
            lines.Add("今日、たまたま引き出しを開けたら、今までのノートがたくさん出てきた。読んでいると、今までの努力を思い出してきた。");
            lines.Add("引き出しのノートを見て、頑張りたい気持ちを思い出してきた。大丈夫。まだやれる。今日は一日中勉強した。");
            lines.Add("今日は一日中勉強をした。忘れていたところもバッチリ思い出した。");
            lines.Add("もうすぐ司法試験本番だ。すでにスパートはかかっている。このままいけばいける。");
            lines.Add("もうすぐ司法試験だ。このときのために、ずっと勉強してきた。応援してくれる家族や友達にいい報告をするためにも、一日目以降、勝負だ。");
            lines.Add("今日まで司法試験だった。合否はまだわからない。自分の持てる全てをぶつけた。");
            lines.Add("やることはないが、試験の結果が気になって、心が落ち着かない一日だった。");
            lines.Add("合格だ。合格だった。");
            lines.Add("今日は家族やら友達やらから連絡の絶えない日だった。みんな自分のことのように喜んでくれた。こんなに喜んでくれるのも、きっと自分が、ずっと頑張ってきたからだと思う。過去からの努力が、「今」を創る。これからも、努力はやめないだろう。そこから生まれる「未来」のために。");
        }
        if(status == "muscle")
        {
            lines.Add("今日は筋トレをした。少しづつ筋肉がついてきたみたいだ");
            lines.Add("今日は筋トレをした。腕が太くなってきた。");
            lines.Add("今日は筋トレをした。足が太くなってきた。");
            lines.Add("今日は筋トレをした。胸板が厚くなってきた。");
            lines.Add("今日は筋トレをした。首が太くなってきた。");
            lines.Add("今日は筋トレをした。友達に脳みそまで筋肉になったんじゃないのかと言われた。筋トレをした。");
            lines.Add("今日は筋トレをした。もっと筋肉をつけなければ。");
            lines.Add("諦めずに筋トレをした。");
            lines.Add("今日は筋トレをした。");
            lines.Add("筋トレ");
            lines.Add("筋肉を");
            lines.Add("筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉筋肉・・・・・・");
        }
        if(status == "occult")
        {
            lines.Add("最近、ふと本棚を見るとオカルト本がたくさんあることに気づいた。今日はそのうちの一つを読み耽った。");
            lines.Add("前に読んだオカルト本があまりに面白く、続編を見つけたので買ってしまった。未確認生物に関するものだ。");
            lines.Add("今日は未確認生物に関する論文を読んだ。");
            lines.Add("今日、近くの池で未確認生物を見た気がする。那須湖で見つけたので、ナッスーと名付けよう");
            lines.Add("今日はすごい書籍を見つけた。なんと黒魔術に関する技術がたくさん載っているのだ！すばらしい！！しばらくはこれを読もうと思う。");
            lines.Add("今日はあの書物を読み終えた。醜くも美しい黒魔術の数々を早く試したくて仕方がない。");
            lines.Add("今日は儀式に使う小物をホームセンターに買いに行った。何故かたくさんの人に見られた。私のローブがどこか汚れていたろうか？気をつけよう。");
            lines.Add("今日は昨日揃えられなかったアイテムをネットで注文した。おかげで持ち金がだいぶ減ったが、些細な問題だ。私はこの世界の真理の探究に赴くのだから。");
            lines.Add("今日は部屋を魔術用に改装した。まだ全て終わってはいないが、だいぶ魔術らしい自室になってきた。明日も頑張ろう。");
            lines.Add("今日、全ての作業を終え、ついに私は晴れて黒魔術師となった。明日からは、この世の真理を黒魔術で解き明かす旅が始まる。笑いが止まらない。");
            lines.Add("久しぶりに会った旧友に、頭がおかしくなったと言われた。悲しいことだ。友が人の心を失い、平気で人を嘲笑するようになろうとは。");
            lines.Add("今日は自室で、儀式をしていた。その時、深淵より我を呼ぶ声が聞こえたのだ。その声に従うままに、我は儀式を進めた。途中で声は聞こえなくなってしまったが、これからも儀式を続けていけば、また彼の声を聞くことができるだろう。私は確かに、真理に近づいている。フフフフ・・・・ハハハハハハハハハハハハハハハハハハハハハ！！！！");
        }
        if (status == "fail")
        {
            lines.Add("町で懐かしいカードゲームを見つけた。買ったはいいが遊ぶ相手がいなかった。");
            lines.Add("ネットで対戦ゲームを買った。買ったはいいが遊ぶ相手がいなかった。オンライン対戦もあるがやはり違う。");
            lines.Add("書店で「友達に自慢できるテクニック５選」という本を買った。自慢できる相手がいなかった。");
            lines.Add("12月24日、今日はクリスマスイブだ。しかし相手はいなかった。");
            lines.Add("12月25日、今日はクリスマスだ。恋人はおろか友達すらいなかった。リア充爆発しろ。");
            lines.Add("病気が発覚した。入院しなければならなくなった");
            lines.Add("病院だ。暇だ。");
            lines.Add("病院だ。誰もお見舞いにきてはくれない。");
            lines.Add("検査の類は終わった。もうすぐ手術だそうだ。こわい。");
            lines.Add("手術は成功しなかったらしい。末期まで病状が進んでいたようだ。長い間一人だったせいで、誰も気づいてはくれなかった。");
            lines.Add("今日はもう何も書く気がなくなった。");
            lines.Add("どうして誰も応援してくれなかったんだろう。どうしてだれも泣いてくれないんだろう。どうして一人でホスピスに来なければならなかったんだろう。どうしてずっとひと");
        }
    }
}

public class FutureManager : MonoBehaviour
{
    public CalendarManager CM;
    public int linesManage = 0;
    public List<int> rands = new List<int>();
    public Ending ending;
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Random.InitState(System.DateTime.Now.Millisecond);
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        GM.user1.checkEnding();
        createEnding(GM.user1.ending);
        setLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createEnding(string status)
    {
        ending = new Ending(status);
    }

    public void setLine()
    {
        rands.Clear();
        if(ending.ending_status != "muscle" && ending.ending_status != "occult" && ending.ending_status != "fail")
        {
            while (rands.Count != 2)
            {
                int rand = Random.Range(1, 30);
                if (!rands.Contains(rand))
                {
                    rands.Add(rand);
                }
            }
        }
        else
        {
            while (rands.Count != 1)
            {
                int rand = Random.Range(1, 30);
                if (!rands.Contains(rand))
                {
                    rands.Add(rand);
                }
            }
        }

        rands.Sort();
        for (int i = 0; i < rands.Count; i++)
        {
            CM.dayPanels[rands[i]].GetComponent<FutureDay>().Set(ending.lines[linesManage]);
            linesManage++;
        }
    }

    public GameObject DarkPanel;
    public void ReturnToTitle()
    {
        if(CM.month == 12)
        {
            DarkPanel.GetComponent<SceneChange_DarkTurn>().nextScene = 0;
            DarkPanel.GetComponent<SceneChange_DarkTurn>().startTurn_in();
        }
    }
}
