using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    [SerializeField] private string MainMenu;
    [SerializeField] Animator transitionAnim;

    private void OnTriggerEnter2D(Collider2D player)
    {

        if (player.CompareTag("Player"))
        {
            Debug.Log("Enter gate");
            transitionAnim.SetTrigger("End");
            SceneManager.LoadScene(MainMenu);
            transitionAnim.SetTrigger("Start");


        }
    }
}
