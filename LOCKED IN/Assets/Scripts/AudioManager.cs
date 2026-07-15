using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("------- Audio Soure -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;


    [Header("------- Audio Clip -------")]
    public AudioClip background;
    public AudioClip Attack;
    public AudioClip CarrotSummon;
    public AudioClip Sucking;
    public AudioClip Gunfire;
    public AudioClip SwordSwing;
    public AudioClip Beamshoot;
    public AudioClip TakeDamaged;
    //Add more i ran out of idea

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            
        }

        else
        {
            Destroy(gameObject);
        }


    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Ending")
        {
            Destroy(gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            Destroy(gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "Credit")
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
