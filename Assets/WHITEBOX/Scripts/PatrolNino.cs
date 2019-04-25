using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolNino : StateMachineBehaviour
{
    public GameObject[] objetivos;
    public GameObject agent;

    NavMeshAgent navAgent;
    public Animator animator_agent;

    public int Obj;

    public void Awake()
    {
        objetivos = GameObject.FindGameObjectsWithTag("obj");
        Obj = 0;
    }

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.gameObject;
        animator_agent = agent.GetComponent<Animator>();

        navAgent = agent.GetComponent<NavMeshAgent>();

        siguienteObjetivo();

    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if ((!navAgent.pathPending && navAgent.remainingDistance < 0.5f)) //si el agente se acerca a 0.5 del objetivo, cambiar al siguiente
        {
            animator_agent.SetBool("Move", false);
        }
    }

    public void siguienteObjetivo()
    {
        navAgent.destination = objetivos[Obj].transform.position;
        Obj++;
        Obj %= objetivos.Length;
    }
}