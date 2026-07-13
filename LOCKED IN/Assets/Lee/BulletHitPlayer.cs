using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletHitPlayer : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D player)
    {

        if (player.CompareTag("Player"))
        {
            Destroy(gameObject);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
