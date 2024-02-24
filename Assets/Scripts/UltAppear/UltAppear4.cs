using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltAppear4 : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.destroyUlt4)
        {
            Destroy(this.gameObject);
        }

        if (GameManager.Instance.whichTurn == 4)
        {
            RectTransform buttonRectTransform = button.GetComponent<RectTransform>();
            buttonRectTransform.anchoredPosition = new Vector2(165f, 50f);
        }
    }
}
