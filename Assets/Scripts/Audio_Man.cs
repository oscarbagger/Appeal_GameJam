using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Man : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource SFX;

    [Header("Audio clips")]
    public AudioClip Background_intro;
    public AudioClip Background_Loop;
    public AudioClip Background_End;
    public AudioClip SFX_1;
    public AudioClip SFX_2;
    public AudioClip SFX_3;

    private void Start()
    {
        music.clip = Background_intro;
        music.Play();
    }

}
