using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EM8 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.Gamestart)
        {
            // transform���擾
            Transform myTransform = this.transform;

            // ���W���擾
            Vector2 pos = myTransform.position;

            //�^���̐������`
            if (pos.y >= 4f)
            {
                pos.x -= 0.01f * GameManager.Instance.enemyMul;
            }
            if (pos.x <= -2f)
            {
                pos.y -= 0.01f * GameManager.Instance.enemyMul;
            }
            if (pos.y <= 1f)
            {
                pos.x += 0.01f * GameManager.Instance.enemyMul;
            }
            if (pos.x >= 2f)
            {
                pos.y += 0.01f * GameManager.Instance.enemyMul;
            }

            myTransform.position = pos;  // ���W��ݒ�

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
