using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public GameObject doot;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("POKE", 0.2f, 0.4f);
    }

    public void POKE()
    {
        Instantiate(doot, transform.position, doot.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
