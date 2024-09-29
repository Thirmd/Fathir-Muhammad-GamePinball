using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxbumperAudioSource;
    public GameObject sfxswitchAudioSource;
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    private void PlayBGM(){
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition){
        GameObject.Instantiate(sfxbumperAudioSource, spawnPosition, Quaternion.identity);
    }
    public void PlaySFX2(Vector3 spawnPosition){
        GameObject.Instantiate(sfxswitchAudioSource, spawnPosition, Quaternion.identity);
    }
}
