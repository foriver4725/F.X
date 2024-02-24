using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public GameObject pointPrefab; // �_��\���v���n�u�I�u�W�F�N�g
    public float pointSize = 0.1f; // �_�̃T�C�Y

    private List<GameObject> points = new List<GameObject>(); // �_�I�u�W�F�N�g�̃��X�g

    void Update()
    {
        DrawPoints();
    }

    void DrawPoints()
    {
        ClearPoints(); // �_������

        // ���W�̐�����v���Ă��邱�Ƃ��m�F
        if (GameManager.Instance.graphPointsX.Count != GameManager.Instance.graphPointsY.Count)
        {
            Debug.LogError("���W�̐�����v���Ă��܂���B");
            return;
        }

        // �e���W�f�[�^�ɑ΂��ē_��`��
        for (int i = 0; i < GameManager.Instance.graphPointsX.Count; i++)
        {
            float x = GameManager.Instance.graphPointsX[i];
            float y = GameManager.Instance.graphPointsY[i];

            // �_�I�u�W�F�N�g���쐬���A�w�肳�ꂽ���W�ɔz�u
            GameObject point = Instantiate(pointPrefab, new Vector3(x, y, 0f), Quaternion.identity);
            point.transform.localScale = new Vector3(pointSize, pointSize, pointSize);

            // �쐬�����_�I�u�W�F�N�g�����X�g�ɒǉ�
            points.Add(point);
        }
    }

    void ClearPoints()
    {
        // ���X�g���̓_�I�u�W�F�N�g���폜
        foreach (GameObject point in points)
        {
            Destroy(point);
        }

        // ���X�g���N���A
        points.Clear();
    }
}

