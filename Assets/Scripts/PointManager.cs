using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public GameObject score_object = null; // TextMeshProUGUI�I�u�W�F�N�g

    void Start()
    {
    }

    void Update()
    {
        // �I�u�W�F�N�g����TextMeshProUGUI�R���|�[�l���g���擾
        TextMeshProUGUI score_text = score_object.GetComponent<TextMeshProUGUI>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "Pt:" + GameManager.Instance.score_num + "/10000";
    }
}