using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poderes : MonoBehaviour
{
    public int poder;

    //Dash
    public GameObject indicador;
    public float pushPower = 0.05f;
    public CharacterController characterController;
    Vector3 forwardVector;
    GameObject cam;

    //Glitch
    Ray rayo;
    RaycastHit hit;
    public Material m_glitch;

    //VisionInter
    public Color color1 = Color.black;
    public GameObject[] interObj;
    public Camera camcam;

    public Material ObjetosInteractuables_V;
    public Material ObjetosInteractuables_NV;

    public Material ObjetosNOInteractuables_V;
    public Material ObjetosNOInteractuables_NV;
    



    private void Awake()
    {
        interObj = GameObject.FindGameObjectsWithTag("objInter");
    }

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        foreach (GameObject go in interObj)
        {
            go.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            poder = 1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            poder = 2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            poder = 3;
        }

        switch (poder)
        {
            case 1:
                forwardVector = camcam.transform.forward;

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
                break;
            case 2:
                Vector3 forwardVector2 = cam.transform.forward * 8;
                rayo = new Ray(cam.transform.position, forwardVector2);
                Debug.DrawRay(cam.transform.position, forwardVector2, Color.green);

                if (Physics.Raycast(rayo, out hit) && hit.transform.gameObject.layer == 18 && Input.GetKeyUp(KeyCode.Q))
                {
                    hit.transform.gameObject.layer = 19;
                    //hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                    hit.transform.gameObject.GetComponent<Renderer>().material = m_glitch;
                    hit.transform.gameObject.GetComponent<ignoreCharacterControllerCollision>().enabled = true;
                }
                break;
            case 3:
                if (Input.GetKey(KeyCode.Q))
                {
                    camcam.clearFlags = CameraClearFlags.SolidColor;
                    camcam.backgroundColor = color1;

                    Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("Default"));
                    Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("NormalObject"));
                    Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("NoCollisionsObject"));
                    Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("MovableObject"));

                    //indicador.GetComponentsInChildren<Renderer>().material = 
                    //añadir todas las layers, menos las de los object interactuables

                    foreach (GameObject go in interObj)
                    {
                        go.SetActive(true);
                    }
                }

                if (Input.GetKeyUp(KeyCode.Q))
                {
                    camcam.clearFlags = CameraClearFlags.Skybox;

                    Camera.main.cullingMask |= (1 << LayerMask.NameToLayer("Default"));
                    Camera.main.cullingMask |= (1 << LayerMask.NameToLayer("NormalObject"));
                    Camera.main.cullingMask |= (1 << LayerMask.NameToLayer("NoCollisionsObject"));
                    Camera.main.cullingMask |= (1 << LayerMask.NameToLayer("MovableObject"));
                    //añadir todas las layers, menos las de los object interactuables

                    foreach (GameObject go in interObj)
                    {
                        go.SetActive(false);
                    }
                }
                break;

        }

    }
}
