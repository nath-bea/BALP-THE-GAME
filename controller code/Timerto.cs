using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timerto : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    public int TimeLeft = 10;
    public GameObject textt;
    static public bool flip = false;
    // Start is called before the first frame update
    void Start()
    {
        // sets clock to 10 seconds for the correct balp
        TimeLeft = 10;
        // lowers timer by one per second 
        InvokeRepeating("Timer22", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // reset timer if death occours faster than the timer or if the timer happens 
        CounterText.text = TimeLeft.ToString();
        if (TimeLeft == 0 || Input.GetKeyDown("q") || flip == true)
        {
            // reset so it stays at 1 per second to prevent double spawns ( still possible, in 2000 deaths of trying only got once, most likely a frame perfect timing thing so its not important ) 
            CancelInvoke();
            TimeLeft = 10;
            InvokeRepeating("Timer22", 1.0f, 1.0f);
            flip = false;
            //Instantiate(textt, transform.position, textt.transform.rotation);
            //Destroy(gameObject);
        }
       // if(resourceManager.track1 == resourceManager.track2)
       // {
       //     resourceManager.track2++;
       // }
    }

    void Timer22()
    {
        // lowers timer by one
        TimeLeft = TimeLeft - 1;
    }
}

