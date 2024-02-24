using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageToStart : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        audioSource.PlayOneShot(sound1);
        GameManager.Instance.gameReset = true;
        GameManager.Instance.Gamestart = false;
        GameManager.Instance.funcDraw = new List<string>();
        GameManager.Instance.funcCalc = new List<string>();
        GameManager.Instance.funcRealCalc = new List<float>();
        GameManager.Instance.graphPointsX = new List<float>();
        GameManager.Instance.graphPointsY = new List<float>();
        GameManager.Instance.score_num = 0;
        GameManager.Instance.whichTurn = 0;
        GameManager.Instance.ultUseAble1 = false;
        GameManager.Instance.ultUseAble2 = false;
        GameManager.Instance.ultUseAble3 = false;
        GameManager.Instance.ultUseAble4 = false;
        GameManager.Instance.funcViewReset = false;
        GameManager.Instance.destroyUlt1 = false;
        GameManager.Instance.destroyUlt2 = false;
        GameManager.Instance.destroyUlt3 = false;
        GameManager.Instance.destroyUlt4 = false;
        GameManager.Instance.enemyMul = 1;
        GameManager.Instance.countup = 0f;
        GameManager.Instance.funcMakeTimerStart = false;
        GameManager.Instance.drawDeckText = false;
        SceneManager.LoadScene("StageSelect");
    }
}
