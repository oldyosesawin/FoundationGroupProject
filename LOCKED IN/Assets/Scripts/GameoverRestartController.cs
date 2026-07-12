using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverRestartController : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverScreen;

    private bool _isPlaying = true;
    public bool IsPlaying => _isPlaying;




    private void Update()
    {
        if (!_isPlaying && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(2);
            Restart();
        }
        else if (!_isPlaying && Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(0);
        }
    }
    public void GameOver()
    {
        _isPlaying = false;
        _gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
