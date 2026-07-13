using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarrotLeftWithDelay : MonoBehaviour
{

    
    [SerializeField] private GameObject[] targetObjects;

   
    [SerializeField] private float delayInSeconds = 2.0f;

   
    [SerializeField] private float moveSpeed = 5.0f;

    
    [SerializeField] private float moveDuration = 0f;

    private bool isRunning = false;

    
    public void OnButtonClick()
    {
        if (!isRunning)
        {
            StartCoroutine(DelayAndMoveRoutine());
        }
    }

    private IEnumerator DelayAndMoveRoutine()
    {
        isRunning = true;

        
        yield return new WaitForSeconds(delayInSeconds);

        
        float timer = 0f;

        while (moveDuration <= 0f || timer < moveDuration)
        {
            
            foreach (GameObject obj in targetObjects)
            {
                if (obj != null)
                {
                    obj.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                }
            }

            if (moveDuration > 0f)
            {
                timer += Time.deltaTime;
            }

            yield return null; // รอเฟรมถัดไป
        }

        isRunning = false;
    }
}
