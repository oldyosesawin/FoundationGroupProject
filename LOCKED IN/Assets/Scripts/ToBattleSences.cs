using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBattleSences : MonoBehaviour
{
    [SerializeField] private string battleScene;
    [SerializeField] Animator transitionAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
   

    private void OnTriggerEnter2D(Collider2D player)
    {
        
        if (player.CompareTag("Player"))
        {
            Debug.Log("Enter gate");
            transitionAnim.SetTrigger("End");
             SceneManager.LoadScene(battleScene);
            transitionAnim.SetTrigger("Start");
            
            
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
