using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class N02_ButtonPlace : MonoBehaviour
{
    private RectTransform rectTransform; // RectTransformを参照するための変数

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>(); // RectTransformコンポーネントを取得
    }

    // Update is called once per frame
    void Update()
    {
        //(300,-450)にボタンを生成
        int resultX = 300;
        int resultY = -450;
        Vector3 newPosition = new Vector3(resultX, resultY, rectTransform.position.z);
        rectTransform.anchoredPosition3D = newPosition;
    }
}
