using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAwakeScript : MonoBehaviour
{
    private static KeepAwakeScript instance;
    void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
        
    }
}
