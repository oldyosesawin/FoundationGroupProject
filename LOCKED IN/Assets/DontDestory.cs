using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestory : MonoBehaviour
{
    public static DontDestory Instance;
    private void Awake()
    {
        if (Instance != null)
            Destroy(this.gameObject);
        else
        {
            transform.SetParent(null);
            DontDestroyOnLoad(this.gameObject);
            Instance = this;

        }
        
    }
}
