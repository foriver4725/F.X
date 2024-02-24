using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public GameObject score_object = null; // TextMeshProUGUIオブジェクト

    void Start()
    {
    }

    void Update()
    {
        // オブジェクトからTextMeshProUGUIコンポーネントを取得
        TextMeshProUGUI score_text = score_object.GetComponent<TextMeshProUGUI>();
        // テキストの表示を入れ替える
        score_text.text = "Pt:" + GameManager.Instance.score_num + "/10000";
    }
}