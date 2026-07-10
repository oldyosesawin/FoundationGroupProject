using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public static PlayerHp Instance;

    
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
    }

    float playerhp = 20;

    public float CurrentPlayerHP => playerhp;


    public void TakeDamage(float dmgVal)
    {
        playerhp -= dmgVal;
    }

    private void Update()
    {
      
    }




}
