using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] private GameoverRestartController _gamecontroller;
    public static PlayerHp Instance;
    AudioManager audioManager;



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

    float playerhp = 20;

    public float CurrentPlayerHP => playerhp;


    public void TakeDamage(float dmgVal)
    {
        audioManager.PlaySFX(audioManager.TakeDamaged);
        playerhp -= dmgVal;
    }

    public void OutofHP()
    {
        if (playerhp <= 0)
        {
            _gamecontroller.GameOver();
        }
    }

    private void Update()
    {
      
    }




}
