using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagers : MonoBehaviour
{
    [Header ("------------Audio Source--------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;


    [Header ("------------Audio Clip---------------")]
    public AudioClip Background3;
    public AudioClip SFX;

    private void Start()
    {
        musicSource.clip = Background3;
        musicSource.Play();
    }

}
