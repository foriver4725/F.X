
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public UnityEvent<bool> onGameStartChanged = new UnityEvent<bool>();
    private bool gamestart;

    //Gamastartメソッドを定義
    public bool Gamestart
    {
        get { return gamestart; }
        set
        {
            gamestart = value;
            onGameStartChanged.Invoke(gamestart);
        }
    }

    //乱数を定義
    private System.Random random;

    //funcとnumの配列を作成
    public int[] funcArray = {
        1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
    };
    public int[] numArray = {
        1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
    };

    //リストを作成
    public List<string> funcDraw = new List<string>();
    public List<string> funcCalc = new List<string>();
    public List<float> funcRealCalc = new List<float>();
    public List<float> graphPointsX = new List<float>();
    public List<float> graphPointsY = new List<float>();

    public double score_num = 0; // スコア変数

    //解像度を定義
    public float rsl = 0.05f;

    //目標ポイントを定義
    public int goalPoint = 10000;

    //ターン数を定義
    public int whichTurn = 0;

    //必殺技を使用可能かどうか定義
    public bool ultUseAble1 = false;
    public bool ultUseAble2 = false;
    public bool ultUseAble3 = false;
    public bool ultUseAble4 = false;

    //数式の表示をリセット
    public bool funcViewReset = false;

    //Ultボタンの非表示を定義
    public bool destroyUlt1 = false;
    public bool destroyUlt2 = false;
    public bool destroyUlt3 = false;
    public bool destroyUlt4 = false;

    //敵の移動速度の倍数を設定
    public int enemyMul = 1;

    //時間カウントを定義
    public float countup = 0f;

    //関数を作る時間制限を開始
    public bool funcMakeTimerStart = false;

    //「開発中」テキストを表示
    public bool drawDeckText = false;

    //ゲームリセットを定義
    public bool gameReset = false;

    //最大スコアを定義
    public int maxScore = 1000;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        random = new System.Random();
    }

    // Start is called before the first frame update
    void Start()
    {
        // funcArrayとnumArrayの要素をランダムに並び替える
        ShuffleArray(funcArray);
        ShuffleArray(numArray);
    }

    void Update()
    {
        if (gameReset)
        {
            gameReset = false;
            ShuffleArray(funcArray);
            ShuffleArray(numArray);
        }
    }

    // 配列をシャッフルするメソッド
    private void ShuffleArray<T>(T[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}