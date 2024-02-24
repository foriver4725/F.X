using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EM13 : MonoBehaviour
{
    float r = 0.5f;
    float theta = 0f;

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
            r = 0.5f + theta;

            pos.x = r * Mathf.Cos(theta);
            pos.y = 2.5f + r * Mathf.Sin(theta);

            //端についたらワープする
            if (pos.x <= -3 || pos.x >= 3 || pos.y <= 0 || pos.y >= 5)
            {
                r = 0.5f;
                theta = 0f;
                pos.x = 0.5f;
                pos.y = 2.5f;
            }

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
