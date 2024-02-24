using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class E_SendButton : MonoBehaviour
{
    public string buttonText;

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonClick()
    {
        if (GameManager.Instance.Gamestart == false)
        {
            if (GameManager.Instance.funcDraw.Count >= 1)
            {
                GameManager.Instance.funcDraw.Add(buttonText);
                GameManager.Instance.funcCalc.Add(buttonText);
            }
        }
        audioSource.PlayOneShot(sound1);
    }
}
