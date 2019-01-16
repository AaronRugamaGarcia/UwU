using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Idle : StateMachineBehaviour
{
    public GameObject agent;
    public Transform player;

    NavMeshAgent navAgent;
    public Animator animator_agent;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        agent = animator.gameObject;
        animator_agent = agent.GetComponent<Animator>();

        navAgent = agent.GetComponent<NavMeshAgent>();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        float dist = Vector3.Distance(player.position, animator.gameObject.transform.position);

        if (dist <= 2f)
        {
            animator_agent.SetBool("Move", true);
        }
    }
}
