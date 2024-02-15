using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BALP : MonoBehaviour
{

    public void NextScene()
    {
        // checks how far the player has progressed and spawns them in the right level when they hit play 

        if (resourceManager.level == 0)
        {

            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 1");

        }else if (resourceManager.level == 1)
        {

            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 2");

        }
        else if (resourceManager.level == 2)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 3");

        }
        else if (resourceManager.level == 3)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 4");

        }
        else if (resourceManager.level == 4)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 5");

        }
        else if (resourceManager.level == 5)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 6");

        }
        else if (resourceManager.level == 6)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 7");

        }
        else if (resourceManager.level == 7)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 8");

        }
        else if (resourceManager.level == 8)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 9");

        }
        else if (resourceManager.level == 9)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 10");

        }
        else if (resourceManager.level == 10)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 12");

        }
        else if (resourceManager.level == 11)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 11");

        }
        else if (resourceManager.level == 12)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 13");

        }
        else if (resourceManager.level == 13)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 14");

        }
        else if (resourceManager.level == 14)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 15");

        }
        else if (resourceManager.level == 15)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 16");

        }
        else if (resourceManager.level == 16)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 17");

        }
        else if (resourceManager.level == 17)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 18");

        }
        else if (resourceManager.level == 18)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 19");

        }
        else if (resourceManager.level == 19)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 20");

        }
        else if (resourceManager.level == 20)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("Scene 21");

        }
        else if (resourceManager.level == 21)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("End");

        }
    }
    public void rat()
    {
        // secret level unlocks.
        resourceManager.lvl1 = true;
        resourceManager.lvl2 = true;
        resourceManager.lvl3 = true;
        resourceManager.lvl4 = true;
        resourceManager.lvl5 = true;
        resourceManager.lvl6 = true;
        resourceManager.lvl7 = true;
        resourceManager.lvl8 = true;
        resourceManager.lvl9 = true;
        resourceManager.lvl10 = true;
        resourceManager.lvl11 = true;
        resourceManager.lvl12 = true;
        resourceManager.lvl13 = true;
        resourceManager.lvl14 = true;
        resourceManager.lvl15 = true;
        resourceManager.lvl16 = true;
        resourceManager.lvl17 = true;
        resourceManager.lvl18 = true;
        resourceManager.lvl19 = true;
        resourceManager.lvl20 = true;
        resourceManager.lvl21 = true;

        // changes rat type between the 2 
        if (resourceManager.ratType == false)
        {
            resourceManager.ratType = true;
        }
        else
        {
            resourceManager.ratType = false;
        }
    }
    // goes to level selector screen
    public void Selector()
    {
        SceneManager.LoadScene("title");
    }

    public void Exit()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
