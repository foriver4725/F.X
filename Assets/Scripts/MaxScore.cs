using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MaxScore : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI maxScoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("maxScore"))
        {
            int maxScore = PlayerPrefs.GetInt("maxScore", 1000);
            if (maxScore != 1000)
            {
                maxScoreText.text = maxScore.ToString();
            }
        }
    }
}
