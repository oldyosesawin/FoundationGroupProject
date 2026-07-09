using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class AttackHitBox : MonoBehaviour
{
     

    Collider2D Hitbox;
    // Start is called before the first frame update
    void Start()
    {
        Hitbox = GetComponent<Collider2D>();
    }


    public void OpenHitBox()
    {
        Hitbox.enabled = true;
    }
   
    
    public void OffHitBox()
    {
        Hitbox.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
