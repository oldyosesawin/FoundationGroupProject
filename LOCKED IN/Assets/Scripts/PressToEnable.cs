using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PressToEnable : MonoBehaviour
{
    [SerializeField] GameObject Box1;
    [SerializeField] GameObject Box2;
    [SerializeField] GameObject Box3;
    [SerializeField] GameObject Box4;
    [SerializeField] GameObject Attack1;
    [SerializeField] GameObject Attack2;
    [SerializeField] GameObject Player;

    [SerializeField]private Animator anim;
    [SerializeField] private TextMeshProUGUI Dialogue;
    [SerializeField] private GameObject DialogueBox;
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Show()
    {
        StartCoroutine(blah());
    }

    IEnumerator blah()
    {
        Box1.SetActive(true);
        Box2.SetActive(true);
        Box3.SetActive(true);
        Box4.SetActive(true);
        Attack1.SetActive(true);
        Attack2.SetActive(true);
        Player.SetActive(true);
        Dialogue.gameObject.SetActive(true);
        DialogueBox.SetActive(true);
        if (Dialogue.gameObject)
        {
            yield return new WaitForSeconds(2f);
            Dialogue.gameObject.SetActive(false);
        }
        if (DialogueBox.gameObject)
        {
            yield return new WaitForSeconds(0.2f);
            DialogueBox.gameObject.SetActive(false);
        }
       
    }
   


    public void StartAttack()
    {
        anim.SetTrigger("StartAtk");
        
    }

    
}
