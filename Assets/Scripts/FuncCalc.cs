using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncCalc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.funcDraw.Contains("R"))
        {
            GameManager.Instance.ultUseAble1 = false;
            GameManager.Instance.ultUseAble2 = false;
            GameManager.Instance.ultUseAble3 = false;
            GameManager.Instance.ultUseAble4 = false;

            for (int j = 0; j < GameManager.Instance.funcDraw.Count; j++)
            {
                GameManager.Instance.funcDraw.RemoveAt(0);
            }
            for (int j = 0; j < GameManager.Instance.funcCalc.Count; j++)
            {
                GameManager.Instance.funcCalc.RemoveAt(0);
            }
        }

        for (int i = 0; i < GameManager.Instance.funcCalc.Count; i++)
        {
            if (GameManager.Instance.Gamestart == false)
            {
                if (GameManager.Instance.funcCalc[i] == "E")
                {
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "|›|^›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "|" + GameManager.Instance.funcCalc[i - 2] + "|^(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "(sin›)^›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "(sin(" + GameManager.Instance.funcCalc[i - 2] + "))^(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "(cos›)^›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "(cos(" + GameManager.Instance.funcCalc[i - 2] + "))^(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "log[›]›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "log[" + GameManager.Instance.funcCalc[i - 2] + "](" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "›+›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "(" + GameManager.Instance.funcCalc[i - 2] + ")+(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "›-›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "(" + GameManager.Instance.funcCalc[i - 2] + ")-(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "›*›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "(" + GameManager.Instance.funcCalc[i - 2] + ")*(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "›/›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "(" + GameManager.Instance.funcCalc[i - 2] + ")/(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "›^›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 2)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 2 && i - 1 < GameManager.Instance.funcCalc.Count && i - 2 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 2] = "(" + GameManager.Instance.funcCalc[i - 2] + ")^(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                        GameManager.Instance.funcCalc.RemoveAt(i - 1);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "|›|")
                {
                    if (GameManager.Instance.funcCalc.Count <= 1)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 1 && i - 1 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 1] = "|" + GameManager.Instance.funcCalc[i - 1] + "|";
                        GameManager.Instance.funcCalc.RemoveAt(i);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "›*x")
                {
                    if (GameManager.Instance.funcCalc.Count <= 1)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 1 && i - 1 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 1] = "(" + GameManager.Instance.funcCalc[i - 1] + ")*x";
                        GameManager.Instance.funcCalc.RemoveAt(i);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "›/x")
                {
                    if (GameManager.Instance.funcCalc.Count <= 1)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 1 && i - 1 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 1] = "(" + GameManager.Instance.funcCalc[i - 1] + ")/x";
                        GameManager.Instance.funcCalc.RemoveAt(i);
                    }
                    break;
                }
                if (GameManager.Instance.funcCalc[i] == "x^›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 1)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 1 && i - 1 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 1] = "x^(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "›^x")
                {
                    if (GameManager.Instance.funcCalc.Count <= 1)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 1 && i - 1 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 1] = "(" + GameManager.Instance.funcCalc[i - 1] + ")^x";
                        GameManager.Instance.funcCalc.RemoveAt(i);
                    }
                    break;
                }
                if (GameManager.Instance.funcCalc[i] == "sin›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 1)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 1 && i - 1 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 1] = "sin(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "cos›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 1)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 1 && i - 1 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 1] = "cos(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i);
                    }
                    break;
                }

                if (GameManager.Instance.funcCalc[i] == "log›")
                {
                    if (GameManager.Instance.funcCalc.Count <= 1)
                    {
                        GameManager.Instance.funcDraw.RemoveAt(GameManager.Instance.funcDraw.Count - 1);
                        GameManager.Instance.funcCalc.RemoveAt(GameManager.Instance.funcCalc.Count - 1);
                    }
                    if (i >= 1 && i - 1 < GameManager.Instance.funcCalc.Count)
                    {
                        GameManager.Instance.funcCalc[i - 1] = "log(" + GameManager.Instance.funcCalc[i - 1] + ")";
                        GameManager.Instance.funcCalc.RemoveAt(i);
                    }
                    break;
                }
            }
        }
    }
}
