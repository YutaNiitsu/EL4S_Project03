using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public AudioClip[] bgmClips;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        // BGM用のAudioSourceコンポーネントを追加
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;

        PlayBGM(0);
    }

    public void PlayBGM(int index)
    {
        if (index >= 0 && index < bgmClips.Length)
        {
            audioSource.clip = bgmClips[index];
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Invalid BGM index: " + index);
        }
    }

    public void StopBGM()
    {
        audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
