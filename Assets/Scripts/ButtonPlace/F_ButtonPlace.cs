using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class F_ButtonPlace : MonoBehaviour
{
    private RectTransform rectTransform; // RectTransformを参照するための変数

    public int whichNumberToSearch;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>(); // RectTransformコンポーネントを取得
    }

    // Update is called once per frame
    void Update()
    {
        int index = Array.IndexOf(GameManager.Instance.funcArray, whichNumberToSearch);
        int resultX = (index % 2 == 0) ? -300 : -100;
        float resultY;
        switch (index)
        {
            //左半分にボタンを生成
            case 0:
            case 1:
                resultY = -50;
                break;
            case 2:
            case 3:
                resultY = -130;
                break;
            case 4:
            case 5:
                resultY = -210;
                break;
            case 6:
            case 7:
                resultY = -290;
                break;
            case 8:
            case 9:
                resultY = -370;
                break;
            case 10:
            case 11:
                resultY = -450;
                break;
            case 12:
            case 13:
                resultY = -530;
                break;
            case 14:
                resultY = -610;
                break;
            default:
                // それ以外の場合のデフォルト値を設定
                resultY = 0;
                break;
        }
        if (index <= 9 && GameManager.Instance.whichTurn >= Mathf.Floor(index / 2))
        {
            Vector3 newPosition = new Vector3(resultX, resultY, rectTransform.position.z);
            rectTransform.anchoredPosition3D = newPosition;
        }
    }
}



