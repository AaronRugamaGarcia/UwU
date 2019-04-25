using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class FindPlayer : StateMachineBehaviour
{
    public GameObject agent;
    public Transform player;
    NavMeshAgent navAgent;
    public Animator animator_agent;
    public Vector3 posActual;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject.Find("Main Camera").GetComponent<vp_FPCamera>().enabled = false;
        GameObject.Find("Player").GetComponent<vp_FPController>().enabled = false;
        agent = animator.gameObject;
        animator_agent = agent.GetComponent<Animator>();
        navAgent = agent.GetComponent<NavMeshAgent>();
        posActual = agent.transform.position;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        navAgent.destination = player.transform.position;

        if ((!navAgent.pathPending && navAgent.remainingDistance <= 3f))
        {
            navAgent.isStopped = true;
            animator_agent.SetBool("findPlayer", false);
        }
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        navAgent.isStopped = false;

        navAgent.destination = posActual;

        GameObject.Find("Main Camera").GetComponent<vp_FPCamera>().enabled = true;
        GameObject.Find("Player").GetComponent<vp_FPController>().enabled = true;
    }
}
