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

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        walk();
    }

    void walk()
    {
        moveVelocity.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVelocity.x * speed, rb.velocity.y);

        moveVelocity.y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, moveVelocity.y * speed);
    }

}
