using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FuncMakeTimer : MonoBehaviour
{
    private TextMeshProUGUI textComponent;

    public float countup = 0f;
    public float gameCountup = 0f;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();

        if (textComponent == null)
        {
            Debug.LogError("TextMeshProUGUI component not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.whichTurn <= 4)
        {
            if (GameManager.Instance.Gamestart)
            {
                gameCountup += Time.deltaTime;
            }
        }

        if (!GameManager.Instance.Gamestart)
        {
            GameManager.Instance.funcMakeTimerStart = true;
        }

        if (textComponent != null)
        {
            if (countup == 0f)
            {
                textComponent.text = null;
            }
            if (countup != 0f)
            {
                textComponent.text = (30f - (float)Math.Round(countup, MidpointRounding.AwayFromZero)).ToString();
            }
        }

        if (!GameManager.Instance.funcMakeTimerStart)
        {
            countup = 0f;
        }

        if (GameManager.Instance.funcMakeTimerStart)
        {
            if (GameManager.Instance.whichTurn <= 4)
            {
                countup += Time.deltaTime;
            }
            else
            {
                textComponent.color = new Color(1.0f, 1.0f, 0.0f, 1.0f);
                textComponent.text = ((int)Math.Round(gameCountup, MidpointRounding.AwayFromZero)).ToString();
                if (GameManager.Instance.maxScore > (int)Math.Round(gameCountup, MidpointRounding.AwayFromZero))
                {
                    GameManager.Instance.maxScore = (int)Math.Round(gameCountup, MidpointRounding.AwayFromZero);
                }
            }
        }

        if (30f - (float)Math.Round(countup, MidpointRounding.AwayFromZero) <= 0f)
        {
            GameManager.Instance.funcMakeTimerStart = false;
            GameManager.Instance.Gamestart = true;

        }
    }
}
