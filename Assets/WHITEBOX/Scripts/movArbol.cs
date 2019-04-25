using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class movArbol : MonoBehaviour
{
    public GameObject agent;
    public Transform player;
    NavMeshAgent navAgent;

    void Start()
    {
        navAgent = agent.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        navAgent.SetDestination(new Vector3(player.transform.position.x, this.transform.position.y, this.transform.position.z));
    }
}
