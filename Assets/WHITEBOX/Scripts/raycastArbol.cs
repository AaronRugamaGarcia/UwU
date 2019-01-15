using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class raycastArbol : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject arbol;
    NavMeshAgent agent;
    Vector3 forwardVector;
    public bool hitArbol;
    GameObject cam;

    private void Awake()
    {
        cam = GameObject.Find("Main Camera");
        agent = arbol.GetComponent<NavMeshAgent>();
        hitArbol = false;
    }

    void Update()
    {
        Vector3 forwardVector = cam.transform.forward * 8;
        ray = new Ray(cam.transform.position, forwardVector);
        Debug.DrawRay(cam.transform.position, forwardVector, Color.green);

        if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Arbol")
        {
            hitArbol = true;
        }
        else
        {
            hitArbol = false;
        }

        if (hitArbol == true)
        {
            agent.isStopped = true;
        }
        else if (hitArbol == false)
        {
            agent.isStopped = false;
        }
    }
}
