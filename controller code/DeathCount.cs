using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DeathCount : MonoBehaviour
{
    // Start is called before the first frame update


    public TextMeshProUGUI CounterTextd;
    public GameObject textd;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // changes to text at the end to the amount of times you died 
        CounterTextd.text = resourceManager.Deaths.ToString();
    }
}
