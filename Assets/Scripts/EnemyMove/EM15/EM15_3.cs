using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EM15_3 : MonoBehaviour
{
    float theta = 0;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Gamestart)
        {
            // transform‚ğæ“¾
            Transform myTransform = this.transform;

            // À•W‚ğæ“¾
            Vector2 pos = myTransform.position;

            //‰^“®‚Ì¬•ª‚ğ’è‹`
            theta += Time.deltaTime * GameManager.Instance.enemyMul;

            pos.x = -1.5f + 1.25f * Mathf.Cos(theta);
            pos.y = 1.25f + 1.25f * Mathf.Sin(theta);

            myTransform.position = pos;  // À•W‚ğİ’è

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
