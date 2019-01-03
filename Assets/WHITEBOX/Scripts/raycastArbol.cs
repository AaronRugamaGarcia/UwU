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
    public bool hitArbol;

    private void Awake()
    {
        agent = arbol.GetComponent<NavMeshAgent>();
        hitArbol = false;
    }

    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward) * 100;
        ray = new Ray(gameObject.transform.position + transform.up * 2, fwd);
        Debug.DrawRay(gameObject.transform.position + transform.up * 2, fwd, Color.green);

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
