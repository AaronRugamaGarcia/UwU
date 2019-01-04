using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch : MonoBehaviour
{
    Ray rayo;
    RaycastHit hit;
    GameObject cam;
    Vector3 forwardVector;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        Vector3 forwardVector = cam.transform.forward * 8;
        rayo = new Ray(cam.transform.position, forwardVector);
        Debug.DrawRay(cam.transform.position, forwardVector, Color.green);
    }
}
