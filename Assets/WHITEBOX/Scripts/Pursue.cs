using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pursue : StateMachineBehaviour
{
    public GameObject agent;
    public Transform player;
    NavMeshAgent navAgent;
    public Animator animator_agent;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.gameObject;
        animator_agent = agent.GetComponent<Animator>();
        navAgent = agent.GetComponent<NavMeshAgent>();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        navAgent.destination = player.transform.position;       

        if ((!navAgent.pathPending && navAgent.remainingDistance <= 0.1f))
        {
            agent.SetActive(false);
        }
    }

}
