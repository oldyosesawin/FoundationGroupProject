using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverRestartController : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private PlayerHp playerhp;
    public static GameoverRestartController Instance;

    private bool _isPlaying = true;
    public bool IsPlaying => _isPlaying;


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

    private void Update()
    {
        if (!_isPlaying && Input.GetKeyDown(KeyCode.R))
        {
            
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
        Time.timeScale = 1f;
        _gameOverScreen.SetActive(false);
        SceneManager.LoadScene(2);
        
    }


}
