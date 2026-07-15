using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneWithDelay : MonoBehaviour
{

   
    [SerializeField] private string targetSceneName;

    
    [SerializeField] private float startDelay = 2.0f;

    
    [SerializeField] private float transitionDuration = 1.0f;

   
    [SerializeField] private Animator fadeAnimator;

   
    [SerializeField] private string fadeTriggerName = "StartFade";

    private bool isTransitioning = false;

    public void OnButtonClick()
    {
        
        if (!isTransitioning)
        {
            StartCoroutine(WaitAndChangeScene());
        }
    }

    private IEnumerator WaitAndChangeScene()
    {
        isTransitioning = true;

        
        yield return new WaitForSeconds(startDelay);

        
        if (fadeAnimator != null)
        {
            fadeAnimator.SetTrigger(fadeTriggerName);
        }

        
        yield return new WaitForSeconds(transitionDuration);

        
        if (!string.IsNullOrEmpty(targetSceneName))
        {
            SceneManager.LoadScene(targetSceneName);
        }
        else
        {
            Debug.LogError("ยังไม่ได้ใส่ชื่อ Scene ในช่อง Target Scene Name!");
            isTransitioning = false;
        }
    }
}

