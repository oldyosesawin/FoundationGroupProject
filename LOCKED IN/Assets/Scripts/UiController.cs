using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI playerUIText;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerUIText.text = PlayerHp.Instance.CurrentPlayerHP.ToString();
    }
}
