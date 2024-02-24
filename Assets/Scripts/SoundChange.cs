using UnityEngine;

public class SoundChange : MonoBehaviour
{
    [SerializeField] AudioSource source1;
    [SerializeField] AudioSource source2;
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;

    private bool isPlayingBGM1; // BGM1が再生中かどうかを示すフラグ
    private bool isPlayingBGM2; // BGM2が再生中かどうかを示すフラグ

    private void Start()
    {
        GameManager.Instance.onGameStartChanged.AddListener(OnGameStartChanged);

        // ゲーム開始時のBGM再生
        OnGameStartChanged(GameManager.Instance.Gamestart);
    }

    private void OnGameStartChanged(bool gamestart)
    {
        if (gamestart)
        {
            if (isPlayingBGM2)
            {
                source2.Stop();  // BGM2の再生を停止
                isPlayingBGM2 = false;
            }

            if (!isPlayingBGM1)
            {
                source1.clip = clip1;
                source1.Play();
                isPlayingBGM1 = true;
            }
        }
        if (gamestart == false)
        {
            if (isPlayingBGM1)
            {
                source1.Stop();  // BGM1の再生を停止
                isPlayingBGM1 = false;
            }

            if (!isPlayingBGM2)
            {
                source2.clip = clip2;
                source2.Play();
                isPlayingBGM2 = true;
            }
        }
    }
}


