using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter2 : MonoBehaviour
{
    public AudioClip sound;
    AudioSource audioSource;

    void HelpActivate1()
    {
        if (GameManager.Instance.score_num < GameManager.Instance.goalPoint * 0.125f * 1 / 5)
        {
            GameManager.Instance.score_num += GameManager.Instance.goalPoint * 0.125f * 1 / 5;
            GameManager.Instance.enemyMul *= 2;
            audioSource.PlayOneShot(sound);
        }
    }

    void HelpActivate2()
    {
        if (GameManager.Instance.score_num < GameManager.Instance.goalPoint * 0.125f * 2 / 5)
        {
            GameManager.Instance.score_num += GameManager.Instance.goalPoint * 0.125f * 1 / 5;
            GameManager.Instance.enemyMul *= 2;
            audioSource.PlayOneShot(sound);
        }
    }

    void HelpActivate3()
    {
        if (GameManager.Instance.score_num < GameManager.Instance.goalPoint * 0.125 * 3 / 5)
        {
            GameManager.Instance.score_num += GameManager.Instance.goalPoint * 0.125 * 1 / 5;
            GameManager.Instance.enemyMul *= 2;
            audioSource.PlayOneShot(sound);
        }
    }

    void HelpActivate4()
    {
        if (GameManager.Instance.score_num < GameManager.Instance.goalPoint * 0.125 * 4 / 5)
        {
            GameManager.Instance.score_num += GameManager.Instance.goalPoint * 0.125 * 1 / 5;
            GameManager.Instance.enemyMul *= 2;
            audioSource.PlayOneShot(sound);
        }
    }

    void HelpActivate5()
    {
        if (GameManager.Instance.score_num < GameManager.Instance.goalPoint * 0.125 * 5 / 5)
        {
            GameManager.Instance.score_num += GameManager.Instance.goalPoint * 0.125 * 1 / 5;
            audioSource.PlayOneShot(sound);
        }
    }

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (GameManager.Instance.Gamestart && GameManager.Instance.whichTurn == 1)
        {
            GameManager.Instance.countup += Time.deltaTime;

            if (GameManager.Instance.countup >= 10f)
            {
                if (GameManager.Instance.countup >= 20f)
                {
                    if (GameManager.Instance.countup >= 30f)
                    {
                        if (GameManager.Instance.countup >= 40f)
                        {
                            if (GameManager.Instance.countup >= 50f)
                            {
                                HelpActivate5();
                            }
                            else
                            {
                                HelpActivate4();
                            }
                        }
                        else
                        {
                            HelpActivate3();
                        }
                    }
                    else
                    {
                        HelpActivate2();
                    }
                }
                else
                {
                    HelpActivate1();
                }
            }
        }
    }
}
