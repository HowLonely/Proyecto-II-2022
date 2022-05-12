using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public PlayerMovement control;
    public float horizontalMove = 0f;
    public float runSpeed = 40f;
    public bool jump = false;
    // Update is called once per frame
    void Update()
    {
        horizontalMove =  Input.GetAxisRaw("Horizontal") * runSpeed;

        if(Input.GetButtonDown("Jump")) 
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        control.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}