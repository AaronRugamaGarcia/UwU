using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleBuzones : MonoBehaviour
{
    Ray rayo;
    RaycastHit hit;
    public GameObject cam;

    private void Awake()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 forwardVector2 = cam.transform.forward * 5;
        rayo = new Ray(cam.transform.position, forwardVector2);
        Debug.DrawRay(cam.transform.position, forwardVector2, Color.red);

        if (Physics.Raycast(rayo, out hit))
        {
            Debug.Log(hit);
        }
    }
}
