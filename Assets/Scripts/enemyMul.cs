using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyMul : MonoBehaviour
{
    private TextMeshProUGUI textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();

        if (textComponent == null)
        {
            Debug.LogError("TextMeshProUGUI component not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (textComponent != null)
        {
            textComponent.text = "Å~" + GameManager.Instance.enemyMul;
        }
    }
}
