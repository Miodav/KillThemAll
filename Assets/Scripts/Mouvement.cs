using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mouvement : MonoBehaviour
{
    private Rigidbody2D rb2g;
    public float speed = 5;
    private bool FacingRight;
    private Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        FacingRight = true;
        rb2g = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        rb2g.freezeRotation = true;
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 mouvement = new Vector2(h*speed, v*speed);
        rb2g.velocity = mouvement;
        Flip(h);
        if (Math.Abs(h) > 0.01f)
        {
            anime.SetFloat("speed", speed);
        }
        else
        {
            anime.SetFloat("speed", 0f);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            anime.SetTrigger("attack");
        }
    }
        
    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !FacingRight || horizontal < 0 && FacingRight)
        {
            FacingRight = !FacingRight;
            transform.Rotate(0f, 180f, 0f);
        }
    }


}
