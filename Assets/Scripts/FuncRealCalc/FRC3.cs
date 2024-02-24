using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FRC3 : MonoBehaviour
{
    //calcメソッドを提議
    float calc(float inputX, float inputY)
    {
        //初期化
        GameManager.Instance.funcRealCalc = new List<float>();

        //以下計算
        if (GameManager.Instance.funcDraw.Count != 0)
        {
            for (int i = 0; i < GameManager.Instance.funcDraw.Count; i++)
            {
                if (GameManager.Instance.funcDraw[i] == "|○|^○")
                {
                    GameManager.Instance.funcRealCalc.Add(1100001);
                }
                if (GameManager.Instance.funcDraw[i] == "(sin○)^○")
                {
                    GameManager.Instance.funcRealCalc.Add(1100002);
                }
                if (GameManager.Instance.funcDraw[i] == "(cos○)^○")
                {
                    GameManager.Instance.funcRealCalc.Add(1100003);
                }
                if (GameManager.Instance.funcDraw[i] == "log[○]○")
                {
                    GameManager.Instance.funcRealCalc.Add(1100004);
                }
                if (GameManager.Instance.funcDraw[i] == "○*○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000001);
                }
                if (GameManager.Instance.funcDraw[i] == "○/○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000002);
                }
                if (GameManager.Instance.funcDraw[i] == "○^○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000003);
                }
                if (GameManager.Instance.funcDraw[i] == "|○|")
                {
                    GameManager.Instance.funcRealCalc.Add(1000004);
                }
                if (GameManager.Instance.funcDraw[i] == "○*x")
                {
                    GameManager.Instance.funcRealCalc.Add(1000005);
                }
                if (GameManager.Instance.funcDraw[i] == "○/x")
                {
                    GameManager.Instance.funcRealCalc.Add(1000006);
                }
                if (GameManager.Instance.funcDraw[i] == "x^○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000007);
                }
                if (GameManager.Instance.funcDraw[i] == "○^x")
                {
                    GameManager.Instance.funcRealCalc.Add(1000008);
                }
                if (GameManager.Instance.funcDraw[i] == "sin○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000009);
                }
                if (GameManager.Instance.funcDraw[i] == "cos○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000010);
                }
                if (GameManager.Instance.funcDraw[i] == "log○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000011);
                }
                if (GameManager.Instance.funcDraw[i] == "○+○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000012);
                }
                if (GameManager.Instance.funcDraw[i] == "○-○")
                {
                    GameManager.Instance.funcRealCalc.Add(1000013);
                }
                if (GameManager.Instance.funcDraw[i] == "-3")
                {
                    GameManager.Instance.funcRealCalc.Add(-3);
                }
                if (GameManager.Instance.funcDraw[i] == "-2")
                {
                    GameManager.Instance.funcRealCalc.Add(-2);
                }
                if (GameManager.Instance.funcDraw[i] == "-1")
                {
                    GameManager.Instance.funcRealCalc.Add(-1);
                }
                if (GameManager.Instance.funcDraw[i] == "10")
                {
                    GameManager.Instance.funcRealCalc.Add(10);
                }
                if (GameManager.Instance.funcDraw[i] == "1")
                {
                    GameManager.Instance.funcRealCalc.Add(1);
                }
                if (GameManager.Instance.funcDraw[i] == "2")
                {
                    GameManager.Instance.funcRealCalc.Add(2);
                }
                if (GameManager.Instance.funcDraw[i] == "3")
                {
                    GameManager.Instance.funcRealCalc.Add(3);
                }
                if (GameManager.Instance.funcDraw[i] == "e")
                {
                    GameManager.Instance.funcRealCalc.Add(Mathf.Exp(1));
                }
                if (GameManager.Instance.funcDraw[i] == "π")
                {
                    GameManager.Instance.funcRealCalc.Add(Mathf.PI);
                }
                if (GameManager.Instance.funcDraw[i] == "x")
                {
                    GameManager.Instance.funcRealCalc.Add(inputX);
                }
                if (GameManager.Instance.funcDraw[i] == "y")
                {
                    GameManager.Instance.funcRealCalc.Add(inputY);
                }
                if (GameManager.Instance.funcDraw[i] == "R")
                {
                    GameManager.Instance.funcRealCalc.Add(1000000);
                }
            }

            if (GameManager.Instance.funcRealCalc.Contains(1000000))
            {
                for (int j = 0; j < GameManager.Instance.funcRealCalc.Count; j++)
                {
                    GameManager.Instance.funcRealCalc.RemoveAt(0);
                }
            }

            for (int h = 0; h < GameManager.Instance.funcDraw.Count; h++)
            {
                for (int i = 0; i < GameManager.Instance.funcRealCalc.Count; i++)
                {
                    if (GameManager.Instance.funcRealCalc[i] == 1100001)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = Mathf.Pow(Mathf.Abs(GameManager.Instance.funcRealCalc[i - 2]), GameManager.Instance.funcRealCalc[i - 1]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1100002)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = Mathf.Pow(Mathf.Sin(GameManager.Instance.funcRealCalc[i - 2]), GameManager.Instance.funcRealCalc[i - 1]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1100003)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = Mathf.Pow(Mathf.Cos(GameManager.Instance.funcRealCalc[i - 2]), GameManager.Instance.funcRealCalc[i - 1]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1100004)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = Mathf.Log(GameManager.Instance.funcRealCalc[i - 1], GameManager.Instance.funcRealCalc[i - 2]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000012)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = GameManager.Instance.funcRealCalc[i - 2] + GameManager.Instance.funcRealCalc[i - 1];
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000013)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = GameManager.Instance.funcRealCalc[i - 2] - GameManager.Instance.funcRealCalc[i - 1];
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000001)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = GameManager.Instance.funcRealCalc[i - 2] * GameManager.Instance.funcRealCalc[i - 1];
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000002)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = GameManager.Instance.funcRealCalc[i - 2] / GameManager.Instance.funcRealCalc[i - 1];
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000003)
                    {
                        if (i >= 2 && i - 1 < GameManager.Instance.funcRealCalc.Count && i - 2 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 2] < 1000000 && GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 2] = Mathf.Pow(GameManager.Instance.funcRealCalc[i - 2], GameManager.Instance.funcRealCalc[i - 1]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                                GameManager.Instance.funcRealCalc.RemoveAt(i - 1);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000004)
                    {
                        if (i >= 1 && i - 1 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 1] = Mathf.Abs(GameManager.Instance.funcRealCalc[i - 1]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000005)
                    {
                        if (i >= 1 && i - 1 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 1] = GameManager.Instance.funcRealCalc[i - 1] * inputX;
                                GameManager.Instance.funcRealCalc.RemoveAt(i);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000006)
                    {
                        if (i >= 1 && i - 1 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 1] = GameManager.Instance.funcRealCalc[i - 1] / inputX;
                                GameManager.Instance.funcRealCalc.RemoveAt(i);
                            }
                        }
                        break;
                    }
                    if (GameManager.Instance.funcRealCalc[i] == 1000007)
                    {
                        if (i >= 1 && i - 1 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 1] = Mathf.Pow(inputX, GameManager.Instance.funcRealCalc[i - 1]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000008)
                    {
                        if (i >= 1 && i - 1 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 1] = Mathf.Pow(GameManager.Instance.funcRealCalc[i - 1], inputX);
                                GameManager.Instance.funcRealCalc.RemoveAt(i);
                            }
                        }
                        break;
                    }
                    if (GameManager.Instance.funcRealCalc[i] == 1000009)
                    {
                        if (i >= 1 && i - 1 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 1] = Mathf.Sin(GameManager.Instance.funcRealCalc[i - 1]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000010)
                    {
                        if (i >= 1 && i - 1 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 1] = Mathf.Cos(GameManager.Instance.funcRealCalc[i - 1]);
                                GameManager.Instance.funcRealCalc.RemoveAt(i);
                            }
                        }
                        break;
                    }

                    if (GameManager.Instance.funcRealCalc[i] == 1000011)
                    {
                        if (i >= 1 && i - 1 < GameManager.Instance.funcRealCalc.Count)
                        {
                            if (GameManager.Instance.funcRealCalc[i - 1] < 1000000)
                            {
                                GameManager.Instance.funcRealCalc[i - 1] = Mathf.Log(GameManager.Instance.funcRealCalc[i - 1], Mathf.Exp(1));
                                GameManager.Instance.funcRealCalc.RemoveAt(i);
                            }
                        }
                        break;
                    }
                }
            }
            return GameManager.Instance.funcRealCalc[0];
        }
        //何も入っていない
        return 10000000f;
    }

    //funcNumberInの定義
    void funcNumberIn()
    {
        for (float i = -3f; i <= 3f; i = i + GameManager.Instance.rsl)
        {
            for (float j = -2.5f; j <= 2.5f; j = j + GameManager.Instance.rsl)
            {
                float calcReturn = calc(i, j);
                if (Mathf.Abs(calcReturn) <= GameManager.Instance.rsl)
                {
                    GameManager.Instance.graphPointsX.Add(i);
                    GameManager.Instance.graphPointsY.Add(j + 2.5f);
                }
            }
        }
    }

    //funcNumberResetの定義
    void funcNumberReset()
    {
        GameManager.Instance.graphPointsX = new List<float>();
        GameManager.Instance.graphPointsY = new List<float>();
    }

    // コルーチン本体
    private IEnumerator DelayCoroutine()
    {
        while (true) // このGameObjectが有効な間実行し続ける
        {
            funcNumberReset();
            funcNumberIn();
            // 1.0秒待つ
            yield return new WaitForSeconds(1.0f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // コルーチンの起動
        StartCoroutine(DelayCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
