using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRoomba : MonoBehaviour
{

    public float radio;
    public float tiempoMovimiento;

    private Transform target;
    private NavMeshAgent agent;
    private float timer;

    void OnEnable()
    {
        agent = this.GetComponent<NavMeshAgent>();
        timer = tiempoMovimiento;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= tiempoMovimiento)
        {
            Vector3 newPos = RandomNavSphere(transform.position, radio, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
