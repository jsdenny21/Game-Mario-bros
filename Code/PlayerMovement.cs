using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float speed = 30f;
    bool jump = false;
    public Collision2D col;
    public Animator anim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * speed;
        anim.SetFloat("move", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }

    }


    private void FixedUpdate()
    {

       controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
       jump = false;

    }

}
