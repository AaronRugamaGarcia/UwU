using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public GameObject indicador;
    public float pushPower = 0.05f;
    public CharacterController characterController;
    Vector3 forwardVector;
    GameObject cam;

    private void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        forwardVector = cam.transform.forward;

        if (Input.GetKey(KeyCode.Q))
        {
            indicador.SetActive(true);
        }
        else
        {
            indicador.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            characterController.Move(forwardVector * pushPower);
            indicador.SetActive(false);
        }
    }
}
