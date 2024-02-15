using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poker : MonoBehaviour
{
    public GameObject spike;

    // spawns the spike
    public void POKE()
    {
        Instantiate(spike, transform.position, spike.transform.rotation);
    }


    // Start is called before the first frame update
    void Start()
    {
        // calls the spike to change pertrude every 4 seconds except for the first time which is 2 secondws to account for the nonexistant spike 
        InvokeRepeating("POKE", 2.0f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
