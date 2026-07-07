using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------- Audio Soure -------")]
    [SerializeField] AudioSource musicSource;
    //[SerializeField] AudioSource SFXSource;


    [Header("------- Audio Clip -------")]
    public AudioClip background;
    //public AudioClip Hit;
    //public AudioClip Attack;
    //public AudioClip Gethit;
    //Add more i ran out of idea

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
