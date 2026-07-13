using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReyvalToBattleAnimation : MonoBehaviour
{
    public Animator animator;
    public string triggerName = "NextAnim";
    public float delayInSeconds = 2.0f;
   
    public void OnButtonClick()
    {
        StartCoroutine(PlayAnimationWithDelay());
    }

    
    private IEnumerator PlayAnimationWithDelay()
    {
        
        yield return new WaitForSeconds(delayInSeconds);

        
        animator.SetTrigger(triggerName);
    }
}