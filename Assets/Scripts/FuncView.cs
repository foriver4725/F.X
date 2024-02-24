using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FuncView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI funcText;

    // Start is called before the first frame update
    void Start()
    {
        funcText.text = "=0";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.funcDraw.Count >= 10)
        {
            funcText.color = new Color(1f, 0f, 0f, 1f);
        }
        else
        {
            funcText.color = new Color(1f, 1f, 1f, 1f);
        }

        if (GameManager.Instance.funcViewReset)
        {
            funcText.text = "=0";
            GameManager.Instance.funcViewReset = false;
        }

        if (GameManager.Instance.funcCalc.Count >= 1)
        {
            funcText.text = GameManager.Instance.funcCalc[0] + "=0";
        }
        else
        {
            funcText.text = "=0";
        }
    }
}
