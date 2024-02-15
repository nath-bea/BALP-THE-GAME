using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int toot = 5;
    // Start is called before the first frame update
    void Start()
    {
        toot = 0;
        InvokeRepeating("spawn", 1.0f, 1.0f);
    }
    public GameObject player;
    public GameObject player2;
    public GameObject spawner;
    public GameObject poop;
    public resourceManager p;
    // Update is called once per frame
    void Update()
    {
        // checks if the player is going to die soon, 

        if( toot == 0 || Input.GetKeyDown("q") || resourceManager.track1 == resourceManager.track2)
        {
            // resets internal timer to keep it 
            CancelInvoke();
            toot = 5;
            InvokeRepeating("spawn", 1.0f, 1.0f);

            resourceManager.Deaths++;

            // checks which rat must be spawned
            if ( resourceManager.ratType == false)
            {
                Instantiate(player, transform.position, player.transform.rotation);
            }else if(resourceManager.ratType == true)
            {
                Instantiate(player2, transform.position, player2.transform.rotation);
            }
            if (resourceManager.track1 == resourceManager.track2)
            {
                // gives precedent to timer to reset.
                Timer.flip = true;
                // ireelevent 
                resourceManager.track2++;
            }

        } 
    }

    // lowers timer by one 
    void spawn()
    {
        toot = toot - 1;
        //Instantiate(player, transform.position, player.transform.rotation);
        //Instantiate(spawner, transform.position, spawner.transform.rotation);
        //Destroy(poop);

    }
}
