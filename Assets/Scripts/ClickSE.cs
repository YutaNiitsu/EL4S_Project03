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
        // SE用のAudioSourceコンポーネントを追加
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public async void ButtonClick()
    {
        PlaySE(0);
        // 一定の待機時間を設ける（SEの再生が完了する時間）
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
