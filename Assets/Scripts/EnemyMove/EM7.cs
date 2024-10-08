using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EM7 : MonoBehaviour
{
    float theta = 0;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Gamestart)
        {
            // transformを取得
            Transform myTransform = this.transform;

            // 座標を取得
            Vector2 pos = myTransform.position;

            //運動の成分を定義
            theta += Time.deltaTime * GameManager.Instance.enemyMul;

            pos.x = 1.5f * Mathf.Cos(theta);
            pos.y = 2.5f + 1.5f * Mathf.Sin(theta);

            myTransform.position = pos;  // 座標を設定

            for (int i = 0; i < GameManager.Instance.graphPointsX.Count; i++)
            {
                if (Mathf.Abs(Mathf.Sqrt(Mathf.Pow(pos.x - GameManager.Instance.graphPointsX[i], 2) + Mathf.Pow(pos.y - GameManager.Instance.graphPointsY[i], 2))) <= GameManager.Instance.rsl * 8)
                {
                    GameManager.Instance.score_num += 1;
                    break;
                }
            }
        }
    }
}
