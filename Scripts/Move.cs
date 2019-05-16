using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Animator animator;
    public float speed = 5;
    //float horizontalMove = 0f;
    public FixedJoystick fixedJoystick;
    // Update is called once per frame
    void FixedUpdate()
    {
        float h = fixedJoystick.Horizontal;
        float v = fixedJoystick.Vertical;

        var rigidbody = GetComponent<Rigidbody2D>();
        //float v = Input.GetAxisRaw("Vertical");
        //float h = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(h));

        rigidbody.velocity = new Vector2(h, v) * speed;
        GetComponent<Animator>().SetInteger("x", (int)h);
        GetComponent<Animator>().SetInteger("y", (int)v);


    }
}
