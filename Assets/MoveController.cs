using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public CharacterController2D controller;

    private float leftRightMove;

    private bool jump;

    private bool crouch;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnLanding()
    {
        animator.SetBool("Jump", false);
    }

    public void OnCrouching(bool crouch)
    {
        animator.SetBool("Crouch", crouch);
    }

    // Update is called once per frame
    void Update()
    {
        leftRightMove = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(leftRightMove));



        if (Input.GetAxisRaw("Vertical") == 1) {
            jump = true;
            animator.SetBool("Jump", jump);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            crouch = true;
            animator.SetBool("Crouch", true);
        }else if (Input.GetButtonUp("Fire2") )
        {
            crouch = false;
            animator.SetBool("Crouch", false);
        }
    }

    void FixedUpdate()
    {
        controller.Move(leftRightMove, crouch, jump);
        jump = false;
        crouch = false;
    }

}
