using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EM6 : MonoBehaviour
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
            pos.x -= 0.01f * GameManager.Instance.enemyMul;

            //�[�ɂ����烏�[�v����
            if (pos.x <= -3)
            {
                pos.x += 6;
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
