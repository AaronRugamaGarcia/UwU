using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objInter : MonoBehaviour
{
    public Camera cam;
    public Color color1 = Color.black;
    public GameObject[] interObj;

    private void Awake()
    {
        interObj = GameObject.FindGameObjectsWithTag("objInter");
    }

    private void Start()
    {
        foreach (GameObject go in interObj)
        {
            go.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = color1;

            Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("Default"));
            Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("NormalObject"));
            Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("NoCollisionsObject"));
            Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("MovableObject"));
            //añadir todas las layers, menos las de los object interactuables

            foreach (GameObject go in interObj)
            {
                go.SetActive(true);
            }
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            cam.clearFlags = CameraClearFlags.Skybox;

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
    }
}
