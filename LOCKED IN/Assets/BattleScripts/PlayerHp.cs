using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] private GameoverRestartController _gamecontroller;
    public static PlayerHp Instance;
    AudioManager audioManager;
    float playerhp = 20;



    private void Awake()
    {
        if (Instance != null)
            Destroy(this.gameObject);
        else
        {
            transform.SetParent(null);
            DontDestroyOnLoad(this.gameObject);
            Instance = this;

        }
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    

    public float CurrentPlayerHP => playerhp;


    public void TakeDamage(float dmgVal)
    {
        audioManager.PlaySFX(audioManager.TakeDamaged);
        playerhp -= dmgVal;
    }



    private void Update()
    {
        if (playerhp == 0)
        {
            _gamecontroller.GameOver();
            playerhp = 20;
        }

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

    public void HPReset()
    {

    }



}
