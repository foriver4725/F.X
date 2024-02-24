using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1 : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        audioSource.PlayOneShot(sound1);
        SceneManager.LoadScene("Stage1");
    }
}
