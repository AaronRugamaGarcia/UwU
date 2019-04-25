using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movimientoConejo : MonoBehaviour
{
    NavMeshAgent agent;

    Ray rayo;
    Ray rayo2;
    Ray rayo3;
    Ray rayo4;
    RaycastHit hit;
    RaycastHit hit2;
    RaycastHit hit3;
    RaycastHit hit4;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward) * 8;
        Vector3 bck = transform.TransformDirection(Vector3.forward) * -8;
        Vector3 rght = transform.TransformDirection(Vector3.right) * 8;
        Vector3 lft = transform.TransformDirection(Vector3.right) * -8;

        rayo = new Ray(agent.transform.position, fwd);
        rayo2 = new Ray(agent.transform.position, bck);
        rayo3 = new Ray(agent.transform.position, rght);
        rayo4 = new Ray(agent.transform.position, lft);

        Debug.DrawRay(agent.transform.position, fwd, Color.green);
        Debug.DrawRay(agent.transform.position, bck, Color.red);
        Debug.DrawRay(agent.transform.position, rght, Color.blue);
        Debug.DrawRay(agent.transform.position, lft, Color.yellow);

        if (Physics.Raycast(rayo, out hit) && hit.transform.tag == "Zanahoria")
        {
            agent.SetDestination(hit.transform.position);
        }
        if (Physics.Raycast(rayo2, out hit2) && hit2.transform.tag == "Zanahoria")
        {
            agent.SetDestination(hit2.transform.position);
        }
        if (Physics.Raycast(rayo3, out hit3) && hit3.transform.tag == "Zanahoria")
        {
            agent.SetDestination(hit3.transform.position);
        }
        if (Physics.Raycast(rayo4, out hit4) && hit4.transform.tag == "Zanahoria")
        {
            agent.SetDestination(hit4.transform.position);
        }
    }
}
