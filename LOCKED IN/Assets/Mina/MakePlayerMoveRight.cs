using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerMoveRight : MonoBehaviour
{
   
    [SerializeField] private GameObject targetObject;

    
    [SerializeField] private float speed = 5.0f;

   
    [SerializeField] private float delayTime = 2.0f;
    AudioManager audioManager;
    private bool isMoving = false;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void OnButtonClick()
    {
        
        if (!isMoving)
        {
            StartCoroutine(StartMoveRoutine());
        }
    }

    private IEnumerator StartMoveRoutine()
    {
       
        yield return new WaitForSeconds(delayTime);

       
        isMoving = true;
        audioManager.PlaySFX(audioManager.Sucking);
    }

    private void Update()
    {
       
        if (isMoving && targetObject != null)
        {
            targetObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
