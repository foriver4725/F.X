
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

    //Gamastart���\�b�h���`
    public bool Gamestart
    {
        get { return gamestart; }
        set
        {
            gamestart = value;
            onGameStartChanged.Invoke(gamestart);
        }
    }

    //�������`
    private System.Random random;

    //func��num�̔z����쐬
    public int[] funcArray = {
        1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
    };
    public int[] numArray = {
        1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
    };

    //���X�g���쐬
    public List<string> funcDraw = new List<string>();
    public List<string> funcCalc = new List<string>();
    public List<float> funcRealCalc = new List<float>();
    public List<float> graphPointsX = new List<float>();
    public List<float> graphPointsY = new List<float>();

    public double score_num = 0; // �X�R�A�ϐ�

    //�𑜓x���`
    public float rsl = 0.05f;

    //�ڕW�|�C���g���`
    public int goalPoint = 10000;

    //�^�[�������`
    public int whichTurn = 0;

    //�K�E�Z���g�p�\���ǂ�����`
    public bool ultUseAble1 = false;
    public bool ultUseAble2 = false;
    public bool ultUseAble3 = false;
    public bool ultUseAble4 = false;

    //�����̕\�������Z�b�g
    public bool funcViewReset = false;

    //Ult�{�^���̔�\�����`
    public bool destroyUlt1 = false;
    public bool destroyUlt2 = false;
    public bool destroyUlt3 = false;
    public bool destroyUlt4 = false;

    //�G�̈ړ����x�̔{����ݒ�
    public int enemyMul = 1;

    //���ԃJ�E���g���`
    public float countup = 0f;

    //�֐�����鎞�Ԑ������J�n
    public bool funcMakeTimerStart = false;

    //�u�J�����v�e�L�X�g��\��
    public bool drawDeckText = false;

    //�Q�[�����Z�b�g���`
    public bool gameReset = false;

    //�ő�X�R�A���`
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
        // funcArray��numArray�̗v�f�������_���ɕ��ёւ���
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

    // �z����V���b�t�����郁�\�b�h
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