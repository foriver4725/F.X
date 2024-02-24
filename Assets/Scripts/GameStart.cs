using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public bool gameEndTimer = false;
    public float countup = 0f;

    void Update()
    {
        if (GameManager.Instance.funcDraw.Contains("E"))
        {
            if (GameManager.Instance.funcDraw[0] != "E" && GameManager.Instance.whichTurn <= 4)
            {
                GameManager.Instance.funcMakeTimerStart = false;
                GameManager.Instance.Gamestart = true;
            }
        }

        if (GameManager.Instance.score_num >= GameManager.Instance.goalPoint * 0.0625 && GameManager.Instance.whichTurn == 0)
        {
            GameManager.Instance.score_num = GameManager.Instance.goalPoint * 0.0625;
            GameManager.Instance.whichTurn = 1;
            GameManager.Instance.funcDraw.Remove("E");
            GameManager.Instance.funcCalc.Remove("E");
            GameManager.Instance.funcViewReset = true;
            GameManager.Instance.Gamestart = false;
            GameManager.Instance.enemyMul = 1;
            GameManager.Instance.countup = 0f;
            GameManager.Instance.funcMakeTimerStart = true;
        }

        if (GameManager.Instance.score_num >= GameManager.Instance.goalPoint * 0.125 && GameManager.Instance.whichTurn == 1)
        {
            GameManager.Instance.score_num = GameManager.Instance.goalPoint * 0.125;
            GameManager.Instance.whichTurn = 2;
            GameManager.Instance.funcDraw.Remove("E");
            GameManager.Instance.funcCalc.Remove("E");
            GameManager.Instance.funcViewReset = true;
            GameManager.Instance.Gamestart = false;
            GameManager.Instance.enemyMul = 1;
            GameManager.Instance.countup = 0f;
            GameManager.Instance.funcMakeTimerStart = true;
        }

        if (GameManager.Instance.score_num >= GameManager.Instance.goalPoint * 0.25 && GameManager.Instance.whichTurn == 2)
        {
            GameManager.Instance.score_num = GameManager.Instance.goalPoint * 0.25;
            GameManager.Instance.whichTurn = 3;
            GameManager.Instance.funcDraw.Remove("E");
            GameManager.Instance.funcCalc.Remove("E");
            GameManager.Instance.funcViewReset = true;
            GameManager.Instance.Gamestart = false;
            GameManager.Instance.enemyMul = 1;
            GameManager.Instance.countup = 0f;
            GameManager.Instance.funcMakeTimerStart = true;
        }

        if (GameManager.Instance.score_num >= GameManager.Instance.goalPoint * 0.5 && GameManager.Instance.whichTurn == 3)
        {
            GameManager.Instance.score_num = GameManager.Instance.goalPoint * 0.5;
            GameManager.Instance.whichTurn = 4;
            GameManager.Instance.funcDraw.Remove("E");
            GameManager.Instance.funcCalc.Remove("E");
            GameManager.Instance.funcViewReset = true;
            GameManager.Instance.Gamestart = false;
            GameManager.Instance.enemyMul = 1;
            GameManager.Instance.countup = 0f;
            GameManager.Instance.funcMakeTimerStart = true;
        }

        if (GameManager.Instance.score_num >= GameManager.Instance.goalPoint * 1.0 && GameManager.Instance.whichTurn == 4)
        {
            GameManager.Instance.score_num = GameManager.Instance.goalPoint * 1.0;
            GameManager.Instance.whichTurn = 5;
            GameManager.Instance.funcDraw.Remove("E");
            GameManager.Instance.funcCalc.Remove("E");
            GameManager.Instance.funcViewReset = true;
            GameManager.Instance.Gamestart = false;
            GameManager.Instance.enemyMul = 1;
            GameManager.Instance.countup = 0f;
            GameManager.Instance.funcMakeTimerStart = true;
            gameEndTimer = true;
        }

        if (gameEndTimer)
        {
            countup += Time.deltaTime;
        }

        if (countup >= 5f)
        {
            PlayerPrefs.SetInt("maxScore", GameManager.Instance.maxScore);
            PlayerPrefs.Save();
            gameEndTimer = false;
            countup = 0f;
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
}