using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class ClickSE : MonoBehaviour
{
    public AudioClip[] seClips;

    private AudioSource audioSource; void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        // SE�p��AudioSource�R���|�[�l���g��ǉ�
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public async void ButtonClick()
    {
        PlaySE(0);
        // ���̑ҋ@���Ԃ�݂���iSE�̍Đ����������鎞�ԁj
        await Task.Delay((int)(seClips[0].length * 1000));

    }

    public void PlaySE(int index)
    {
        if (index >= 0 && index < seClips.Length)
        {
            audioSource.PlayOneShot(seClips[index]);
        }
        else
        {
            Debug.LogError("Invalid SE index: " + index);
        }


    }

}
