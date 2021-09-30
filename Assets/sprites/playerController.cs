using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Collider2D cd;
    public Animator anim;
    private bool gravityOn=true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && gravityOn == true)
        {
            rb.velocity = new Vector2(0, 0);
            rb.gravityScale = 0;
            gravityOn = false;
        }
        else if(Input.GetKeyDown(KeyCode.J) && gravityOn == false)
        {
            rb.gravityScale = 1;
            gravityOn = true;
        }

        if (Input.GetKeyDown(KeyCode.K)&& cd.isTrigger == false)
        {
            rb.gravityScale = 0;
            cd.isTrigger = true;
        }
        else if (Input.GetKeyDown(KeyCode.K) && cd.isTrigger == true)
        {
            rb.gravityScale = 1;
            cd.isTrigger = false;
        }


        if (gravityOn == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("running", true);
                rb.velocity = new Vector2(-5, rb.velocity.y);
                transform.localScale = new Vector2(-0.2f, 0.2f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("running", true);
                rb.velocity = new Vector2(5, rb.velocity.y);
                transform.localScale = new Vector2(0.2f, 0.2f);
            }
            else
            {
                anim.SetBool("running", false);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.velocity.x, 10f);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.position = new Vector2(rb.position.x, rb.position.y+ 0.01f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rb.position = new Vector2(rb.position.x, rb.position.y -0.01f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.position = new Vector2(rb.position.x-0.01f, rb.position.y);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rb.position = new Vector2(rb.position.x+0.01f, rb.position.y);
            }
        }


    }
}
