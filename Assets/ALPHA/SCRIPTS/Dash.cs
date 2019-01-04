using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float pushPower = 0.05f;
    public CharacterController characterController;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            characterController.Move(this.transform.forward * pushPower);
        }
    }
}
