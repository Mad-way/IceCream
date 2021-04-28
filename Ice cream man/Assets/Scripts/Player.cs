using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    public SpriteRenderer sr;
    public Animator anim;


    //public bool faceRight = true;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        walk();
        //Flip();
        //Reflect();
    }

    void walk()
    {
        moveVelocity.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVelocity.x));
        rb.velocity = new Vector2(moveVelocity.x * speed, rb.velocity.y);

        moveVelocity.y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, moveVelocity.y * speed);
    }



    /*void Flip()
    {
        if (moveVelocity.x > 0)
        {
            sr.flipX = false;
        }
        else if (moveVelocity.x < 0)
        {
            sr.flipX = true;
        }
        sr.flipX = moveVelocity.x < 0;
    }
    /*
    void Reflect()
    {
        if ((moveVelocity.x > 0 && !faceRight) || (moveVelocity.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }
*/
}
