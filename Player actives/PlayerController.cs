using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // declare many variables
    public BoxCollider2D stup2;
    public float Speed;
    public float HZ;
    public float JUMP;
    public float Elas;
    public Rigidbody2D P;
    public resourceManager poop;
    public int CorpseType;

    public AudioSource bounce;
    public AudioSource walk;

    public LayerMask GroundL;
    public LayerMask Bounce;
    public LayerMask Death;
    public LayerMask GroundCC1;
    public LayerMask poke;

    public Animator anim;

    

    public float pep;


    // checks if character is touching spike
    bool IsImpal()
    {
        return Physics2D.BoxCast(stup2.bounds.center, stup2.bounds.size, 0f, Vector2.down, .1f, poke);
    }
    // check if character is touch a corpse bounce block
    bool IsBounceCorpse()
    {




        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;



        Debug.DrawRay(position, direction, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, GroundCC1);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    // check if character is touching a purple block
    bool IsDeath()
    {




        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;



        Debug.DrawRay(position, direction, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, Death);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    // check if character is touching a bounce block
    bool IsBounce()
    {




        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;



        Debug.DrawRay(position, direction, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, Bounce);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }
    // check if character is grounded 
    bool IsGrounded()
    {


        return Physics2D.BoxCast(stup2.bounds.center, stup2.bounds.size, 0f, Vector2.down, .1f, GroundL);

        /*
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;



        Debug.DrawRay(position, direction, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, GroundL);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
        */
    }



    // Start is called before the first frame update
    void Start()
    {
        CorpseType = 1;
        Elas = 20;
        // invoke program to kill every 5 seconds 
        InvokeRepeating("corpseProgram", 5.0f, 0.0f);
        
        pep = P.velocity.y;
    }
    public GameObject player;
    public GameObject corpse;
    public GameObject corpseBounce;
    // Update is called once per frame


    void OnTriggerEnter2D(Collider2D other)
    {


        // shouldve used a "Switch Case"
        // honestly dont know why i didnt, its so obvious.


        //checks what level is next when flag is hit and loads it while also unlocking it 
        if(resourceManager.level == 1)
        {
            
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl2 = true;
            SceneManager.LoadScene("Scene 2");
            
            
        } else if (resourceManager.level == 2)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl3 = true;
            SceneManager.LoadScene("Scene 3");
            
        } else if (resourceManager.level == 3)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl4 = true;
            SceneManager.LoadScene("Scene 4");
            
        } else if (resourceManager.level == 4)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl5 = true;
            SceneManager.LoadScene("Scene 5");
            
        }
        else if (resourceManager.level == 5)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl6 = true;
            SceneManager.LoadScene("Scene 6");

        }
        else if (resourceManager.level == 6)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl7 = true;
            SceneManager.LoadScene("Scene 7");

        }
        else if (resourceManager.level == 7)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl8 = true;
            SceneManager.LoadScene("Scene 8");

        }
        else if (resourceManager.level == 8)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl9 = true;
            SceneManager.LoadScene("Scene 9");

        }
        else if (resourceManager.level == 9)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl10 = true;
            SceneManager.LoadScene("Scene 10");

        }
        else if (resourceManager.level == 10)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl11 = true;
            SceneManager.LoadScene("Scene 11");

        }
        else if (resourceManager.level == 11)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl12 = true;
            SceneManager.LoadScene("Scene 12");

        }
        else if (resourceManager.level == 12)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl13 = true;
            SceneManager.LoadScene("Scene 13");

        }
        else if (resourceManager.level == 13)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl14 = true;
            SceneManager.LoadScene("Scene 14");

        }
        else if (resourceManager.level == 14)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl15 = true;
            SceneManager.LoadScene("Scene 15");

        }
        else if (resourceManager.level == 15)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl16 = true;
            SceneManager.LoadScene("Scene 16");

        }
        else if (resourceManager.level == 16)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl17 = true;
            SceneManager.LoadScene("Scene 17");

        }
        else if (resourceManager.level == 17)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl18 = true;
            SceneManager.LoadScene("Scene 18");

        }
        else if (resourceManager.level == 18)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl19 = true;
            SceneManager.LoadScene("Scene 19");

        }
        else if (resourceManager.level == 19)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl20 = true;
            SceneManager.LoadScene("Scene 20");

        }
        else if (resourceManager.level == 20)
        {
            resourceManager.level = resourceManager.level + 1;
            resourceManager.lvl21 = true;
            SceneManager.LoadScene("Scene 21");

        }
        else if (resourceManager.level == 21)
        {
            resourceManager.level = resourceManager.level + 1;
            SceneManager.LoadScene("End");

        }



    }

    void OnCollisionStay2D(Collision2D collision)
    {
        
    }
    void Update()
    {
        

        // keep some variables constant
        Speed = 5;
        JUMP = 15;

        // get horizonal input and apply it to get movement 
        HZ = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * Speed * Time.deltaTime * HZ);
        if ( HZ > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else if ( HZ < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }

        // apply a upwards force if they touch a bounce block 
        if (!IsBounce())
        {

        }
        else
        {
            bounce.Play();
            P.AddForce(Vector2.up * Elas, ForceMode2D.Impulse);
        }

        if (Input.GetButton("Horizontal") && IsGrounded())
        {
            // start walk sound if they are moving and it is not playing
            if (!walk.isPlaying)
            {
                walk.Play();
            }
        }
        else
        {
            // stop walk sound if they arent moving
            walk.Stop();
        }

        // change corpse type if told to 
        if (!IsBounceCorpse())
        {
           
        }
        else
        {
            CorpseType = 2;
        }

        // kill player and increment tracker ( defunct ),  if told to 
        if (!IsDeath() )
        {

        }
        else
        {

            resourceManager.track1++;
            Destroy(player);
        }

        // test code
       /* if(Input.GetKeyDown("t"))
        {

            resourceManager.track1++;
            Destroy(player);
        } */

        
        // check if player is grounded
        if (!IsGrounded())
        {
            
        }
        // check if player is grounded and pressing space 
        if (Input.GetKeyDown("space") && IsGrounded())
        {
            // apply jump force 
            P.AddForce(Vector2.up * JUMP, ForceMode2D.Impulse);


        }

        // kill player if they hit a spike and move tracker ( defunct ) along 
        if (IsImpal())
        {
            resourceManager.track1++;
            Destroy(player);
        }

        // let player jump on corpse chnage blocks
        if (!IsBounceCorpse())
        {
            //poop
        }
        else if (Input.GetKeyDown("space"))
        {

            P.AddForce(Vector2.up * JUMP, ForceMode2D.Impulse);


        }

        // kill player if they hit Q as a automatic death
        if (Input.GetKeyDown("q"))
        {
            if (CorpseType == 1)
            {
                Instantiate(corpse, transform.position, corpse.transform.rotation);
            }
            else if (CorpseType == 2)
            {
                Instantiate(corpseBounce, transform.position, corpseBounce.transform.rotation);
                CorpseType = 1;
            }
            Destroy(player);
            
        }

        if (HZ != 0)
        {
            anim.SetBool("Running", true);
            anim.SetInteger("State", 1);
        }
        else if( HZ == 0)
        {
            anim.SetBool("Running", false);
            anim.SetInteger("State", 0);
        }

        if (P.velocity.y > .1f)
        {
            // jump
            anim.SetInteger("State", 2);
        }
        else if (P.velocity.y < .1f)
        {
            anim.SetInteger("State", 3);
            //fallling 
        }

    }

    void corpseProgram()
    {
        // checks what kind of corpse to spawn
        if(CorpseType == 1)
        {
            Instantiate(corpse, transform.position, corpse.transform.rotation);
        } else if(CorpseType == 2)
        {
            Instantiate(corpseBounce, transform.position, corpseBounce.transform.rotation);
            CorpseType = 1;
        }
        // destroy old player
        Destroy(player);
        
    }
}
