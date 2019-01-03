using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerNiño : MonoBehaviour
{
    public GameObject niñoAgent;
    Animator anim;

    private void Start()
    {
        anim = niñoAgent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("Trigger", true);
        }
    }
}
