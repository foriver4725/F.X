using UnityEngine;

public class SoundChange : MonoBehaviour
{
    [SerializeField] AudioSource source1;
    [SerializeField] AudioSource source2;
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;

    private bool isPlayingBGM1; // BGM1���Đ������ǂ����������t���O
    private bool isPlayingBGM2; // BGM2���Đ������ǂ����������t���O

    private void Start()
    {
        GameManager.Instance.onGameStartChanged.AddListener(OnGameStartChanged);

        // �Q�[���J�n����BGM�Đ�
        OnGameStartChanged(GameManager.Instance.Gamestart);
    }

    private void OnGameStartChanged(bool gamestart)
    {
        if (gamestart)
        {
            if (isPlayingBGM2)
            {
                source2.Stop();  // BGM2�̍Đ����~
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
                source1.Stop();  // BGM1�̍Đ����~
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


