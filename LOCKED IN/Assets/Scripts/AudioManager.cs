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
    public AudioClip Hit;
    public AudioClip AttackReyval;
    public AudioClip AttackVodka;
    public AudioClip Gunfire;
    public AudioClip SwordSwing;
    public AudioClip Beamshoot;
    public AudioClip Gethit;
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
    }

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
