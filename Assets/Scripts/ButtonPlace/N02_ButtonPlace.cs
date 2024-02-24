using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class N02_ButtonPlace : MonoBehaviour
{
    private RectTransform rectTransform; // RectTransform���Q�Ƃ��邽�߂̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>(); // RectTransform�R���|�[�l���g���擾
    }

    // Update is called once per frame
    void Update()
    {
        //(300,-450)�Ƀ{�^���𐶐�
        int resultX = 300;
        int resultY = -450;
        Vector3 newPosition = new Vector3(resultX, resultY, rectTransform.position.z);
        rectTransform.anchoredPosition3D = newPosition;
    }
}
