using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    static public int TimeLeft = 5;
    public GameObject textt;
    static public bool flip = false;
    // Start is called before the first frame update
    void Start()
    {
        TimeLeft = 5;
        InvokeRepeating("Timer22", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        CounterText.text = TimeLeft.ToString();
        if (TimeLeft == 0 || Input.GetKeyDown("q") || flip == true)
        {
            CancelInvoke();
            TimeLeft = 5;
            InvokeRepeating("Timer22", 1.0f, 1.0f);
            flip = false;
            //Instantiate(textt, transform.position, textt.transform.rotation);
            //Destroy(gameObject);
        }
       // if (resourceManager.track1 == resourceManager.track2)
        //{
           // resourceManager.track2++;
        //}
    }

    void Timer22()
    {
        TimeLeft = TimeLeft - 1;
    }
}
