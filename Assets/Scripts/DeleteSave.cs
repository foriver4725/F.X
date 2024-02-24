using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class DeleteSave : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
    public float countup = 0f;

    void Start()
    {
        gameObject.GetComponent<Button>().image.color = Color.yellow;
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
        countup = 0f;
    }

    void Update()
    {
        if (gameObject.GetComponent<Button>().image.color == Color.red)
        {
            countup += Time.deltaTime;
        }

        if (countup >= 3f)
        {
            gameObject.GetComponent<Button>().image.color = Color.yellow;
            countup = 0f;
        }
    }

    // Update is called once per frame
    public void ButtonClick()
    {
        if (gameObject.GetComponent<Button>().image.color == Color.yellow)
        {
            audioSource.PlayOneShot(sound1);
            gameObject.GetComponent<Button>().image.color = Color.red;
            return;
        }
        if (gameObject.GetComponent<Button>().image.color == Color.red)
        {
            countup = 0f;
            audioSource.PlayOneShot(sound2);
            PlayerPrefs.DeleteKey("maxScore");
            gameObject.GetComponent<Button>().image.color = Color.yellow;
            return;
        }
    }
}
