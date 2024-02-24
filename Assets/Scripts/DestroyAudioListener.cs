using UnityEngine;

public class DestroyAudioListener : MonoBehaviour
{
    private void Start()
    {
        // �I�u�W�F�N�g���炷�ׂĂ�AudioListener���擾����
        AudioListener[] audioListeners = FindObjectsOfType<AudioListener>();

        // �I�u�W�F�N�g�ɕ�����AudioListener���A�^�b�`����Ă���ꍇ�̂݁A�ŏ��Ɍ�������AudioListener���폜����
        if (audioListeners.Length > 1)
        {
            AudioListener targetListener = audioListeners[1];
            Destroy(targetListener);
        }
    }
}