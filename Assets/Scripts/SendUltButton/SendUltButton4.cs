using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SendUltButton4 : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonClick()
    {
        if (!GameManager.Instance.ultUseAble1 && !GameManager.Instance.ultUseAble2 && !GameManager.Instance.ultUseAble3)
        {
            GameManager.Instance.ultUseAble4 = true;
            audioSource.PlayOneShot(sound1);
        }
    }
}

