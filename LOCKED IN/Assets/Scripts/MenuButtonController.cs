using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Setting()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void Credit()
    {
        SceneManager.LoadSceneAsync("Credit");
    }

    public void LeaveGame()
    {
        Application.Quit();
    }

    public void ReturntoMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void TotheEnd()
    {
        SceneManager.LoadSceneAsync("Ending");
        
    }
}
