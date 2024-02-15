using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Ground = false;
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Ground = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Ground = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
