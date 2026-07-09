using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PressToEnable : MonoBehaviour
{
    [SerializeField] GameObject Box1;
    [SerializeField] GameObject Box2;
    [SerializeField] GameObject Box3;
    [SerializeField] GameObject Box4;
    [SerializeField] GameObject Box5;
    [SerializeField] GameObject Box6;
    [SerializeField] GameObject Box7;

    [SerializeField]private Animator anim;
    
    void Start()
    {
        // Get and cache the Animator component attached to this GameObject
    }

    void Update()
    {
        
    }

    public void Show()
    {
        Box1.SetActive(true);
        Box2.SetActive(true);
        Box3.SetActive(true);
        Box4.SetActive(true);
        Box5.SetActive(true);
        Box6.SetActive(true);
        Box7.SetActive(true);


    }

    public void StartAttack()
    {
        anim.SetTrigger("StartAtk");
        
    }

    
}
