using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resourceManager : MonoBehaviour
{
    // holds variables for many other scripts 
    public static int level = 0;
    public static int track1 = 0;
    public static int track2 = 1;
    public static int Deaths = 0;
    public static bool ratType = false;
    public static bool lvl1 = true;
    public static bool lvl2 = false;
    public static bool lvl3 = false;
    public static bool lvl4 = false;
    public static bool lvl5 = false;
    public static bool lvl6 = false;
    public static bool lvl7 = false;
    public static bool lvl8 = false;
    public static bool lvl9 = false;
    public static bool lvl10 = false;
    public static bool lvl11 = false;
    public static bool lvl12 = false;
    public static bool lvl13 = false;
    public static bool lvl14 = false;
    public static bool lvl15 = false;
    public static bool lvl16 = false;
    public static bool lvl17 = false;
    public static bool lvl18 = false;
    public static bool lvl19 = false;
    public static bool lvl20 = false;
    public static bool lvl21 = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // move player back to menu if they hit escape 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            level = level - 1;
            SceneManager.LoadScene("Select");
        }
    }
}
