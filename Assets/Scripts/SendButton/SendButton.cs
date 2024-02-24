using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class SendButton : MonoBehaviour
{
    public string changedButtonText;

    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;

    void Start()
    {
        //ComponentÇéÊìæ
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonClick()
    {
        if (GameManager.Instance.Gamestart == false)
        {
            if (GameManager.Instance.ultUseAble1)
            {
                if (changedButtonText != "Åõ")
                {
                    GameManager.Instance.ultUseAble1 = false;
                    GameManager.Instance.destroyUlt1 = true;

                    this.GetComponentInChildren<Image>().color = new Color(1f, 1f, 0f, 1f);
                    this.GetComponentInChildren<TMP_Text>().text = changedButtonText;
                    audioSource.PlayOneShot(sound2);
                }
            }


            if (GameManager.Instance.ultUseAble2)
            {
                if (changedButtonText != "Åõ")
                {
                    GameManager.Instance.ultUseAble2 = false;
                    GameManager.Instance.destroyUlt2 = true;

                    this.GetComponentInChildren<Image>().color = new Color(1f, 1f, 0f, 1f);
                    this.GetComponentInChildren<TMP_Text>().text = changedButtonText;
                    audioSource.PlayOneShot(sound2);
                }
            }


            if (GameManager.Instance.ultUseAble3)
            {
                if (changedButtonText != "Åõ")
                {
                    GameManager.Instance.ultUseAble3 = false;
                    GameManager.Instance.destroyUlt3 = true;

                    this.GetComponentInChildren<Image>().color = new Color(1f, 1f, 0f, 1f);
                    this.GetComponentInChildren<TMP_Text>().text = changedButtonText;
                    audioSource.PlayOneShot(sound2);
                }
            }


            if (GameManager.Instance.ultUseAble4)
            {
                if (changedButtonText != "Åõ")
                {
                    GameManager.Instance.ultUseAble4 = false;
                    GameManager.Instance.destroyUlt4 = true;

                    this.GetComponentInChildren<Image>().color = new Color(1f, 1f, 0f, 1f);
                    this.GetComponentInChildren<TMP_Text>().text = changedButtonText;
                    audioSource.PlayOneShot(sound2);
                }
            }

            if (!GameManager.Instance.ultUseAble1 && !GameManager.Instance.ultUseAble2 && !GameManager.Instance.ultUseAble3 && !GameManager.Instance.ultUseAble4)
            {

                if (GameManager.Instance.funcDraw.Count <= 9)
                {
                    string buttonText = this.GetComponentInChildren<TMP_Text>().text;
                    GameManager.Instance.funcDraw.Add(buttonText);
                    GameManager.Instance.funcCalc.Add(buttonText);
                }

                audioSource.PlayOneShot(sound1);

            }
        }
    }
}

