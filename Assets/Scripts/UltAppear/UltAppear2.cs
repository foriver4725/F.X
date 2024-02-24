using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltAppear2 : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.destroyUlt2)
        {
            Destroy(this.gameObject);
        }

        if (GameManager.Instance.whichTurn == 2)
        {
            RectTransform buttonRectTransform = button.GetComponent<RectTransform>();
            buttonRectTransform.anchoredPosition = new Vector2(-155f, 50f);
        }
    }
}
