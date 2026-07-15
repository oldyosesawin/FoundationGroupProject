using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MinaPressToEnable : MonoBehaviour
{
    [SerializeField] GameObject Box1;
    [SerializeField] GameObject Box2;
    [SerializeField] GameObject Box3;
    [SerializeField] GameObject Box4;
    [SerializeField] GameObject Box5;
    [SerializeField] GameObject Box6;
    [SerializeField] GameObject Player;

    [SerializeField] private Animator anim;
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
        Box5.SetActive(true);
    
        Player.SetActive(true);
        Dialogue.gameObject.SetActive(true);
        DialogueBox.SetActive(true);
        if (Box6.gameObject)
        {
            yield return new WaitForSeconds(4f);
            Box6.SetActive(true);
        }
        if (DialogueBox.gameObject)
        {
            yield return new WaitForSeconds(2f);
            DialogueBox.gameObject.SetActive(false);
        }
        if (Dialogue.gameObject)
        {
            yield return new WaitForSeconds(1f);
            Dialogue.gameObject.SetActive(false);
        }
    }



    public void StartAttack()
    {
        anim.SetTrigger("StartAtk");

    }
}
