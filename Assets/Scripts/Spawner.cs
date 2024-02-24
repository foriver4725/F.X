using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public GameObject pointPrefab; // 点を表すプレハブオブジェクト
    public float pointSize = 0.1f; // 点のサイズ

    private List<GameObject> points = new List<GameObject>(); // 点オブジェクトのリスト

    void Update()
    {
        DrawPoints();
    }

    void DrawPoints()
    {
        ClearPoints(); // 点を消去

        // 座標の数が一致していることを確認
        if (GameManager.Instance.graphPointsX.Count != GameManager.Instance.graphPointsY.Count)
        {
            Debug.LogError("座標の数が一致していません。");
            return;
        }

        // 各座標データに対して点を描画
        for (int i = 0; i < GameManager.Instance.graphPointsX.Count; i++)
        {
            float x = GameManager.Instance.graphPointsX[i];
            float y = GameManager.Instance.graphPointsY[i];

            // 点オブジェクトを作成し、指定された座標に配置
            GameObject point = Instantiate(pointPrefab, new Vector3(x, y, 0f), Quaternion.identity);
            point.transform.localScale = new Vector3(pointSize, pointSize, pointSize);

            // 作成した点オブジェクトをリストに追加
            points.Add(point);
        }
    }

    void ClearPoints()
    {
        // リスト内の点オブジェクトを削除
        foreach (GameObject point in points)
        {
            Destroy(point);
        }

        // リストをクリア
        points.Clear();
    }
}

