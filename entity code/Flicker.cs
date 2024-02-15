using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // triggers spike destroy after 2 seconds 
        InvokeRepeating("POKE", 0.2f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void POKE()
    {
        // destroys spike nope, dosent, broken, unimportant
        Destroy(gameObject);
    }
}
