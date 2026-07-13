using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneWithDelay : MonoBehaviour
{
    [SerializeField] private string targetSceneName;
    [SerializeField] private float delayInSeconds = 2.0f;
    //AudioManager audioManager;
    // Start is called before the first frame update

    //private void Awake()
    //{
    //    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    //}
    public void OnButtonClick()
    {
        //audioManager.PlaySFX(audioManager.Attack);
        StartCoroutine(WaitAndChangeScene());
    }

    private IEnumerator WaitAndChangeScene()
    {
        
        yield return new WaitForSeconds(delayInSeconds);

        
        if (!string.IsNullOrEmpty(targetSceneName))
        {
            SceneManager.LoadScene(targetSceneName);
        }
        else
        {
            Debug.LogError("ยังไม่ได้ใส่ชื่อ Scene ในช่อง Target Scene Name!");
        }
    }
}

