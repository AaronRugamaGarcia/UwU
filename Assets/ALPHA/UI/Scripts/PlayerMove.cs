using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController charControl;

    public float walkSpeed;

    //public Animator anim;

    private void Awake()
    {
        charControl = GetComponent<CharacterController>();
    }

    private void Update()
    {
        MovePlayer();

        /*if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("isGrabbing", true);
        }


        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))

        {
            anim.SetBool("isWalking", true);
        }

        if (!Input.anyKey)
        {
            anim.SetBool("isWalking", false);
        }*/
    }

    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal") * walkSpeed;
        float vert = Input.GetAxis("Vertical") * walkSpeed;

        Vector3 moveDirSide = transform.right * horiz * walkSpeed;
        Vector3 moveDirForward = transform.forward * vert * walkSpeed;

        charControl.SimpleMove(moveDirSide);
        charControl.SimpleMove(moveDirForward);
    }

    /*public void stopGrabbing()
    {
        anim.SetBool("isGrabbing", false);
    }*/
}
