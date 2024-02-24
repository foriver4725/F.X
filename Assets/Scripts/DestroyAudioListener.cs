using UnityEngine;

public class DestroyAudioListener : MonoBehaviour
{
    private void Start()
    {
        // オブジェクトからすべてのAudioListenerを取得する
        AudioListener[] audioListeners = FindObjectsOfType<AudioListener>();

        // オブジェクトに複数のAudioListenerがアタッチされている場合のみ、最初に見つかったAudioListenerを削除する
        if (audioListeners.Length > 1)
        {
            AudioListener targetListener = audioListeners[1];
            Destroy(targetListener);
        }
    }
}