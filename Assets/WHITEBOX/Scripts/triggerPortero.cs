using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPortero : MonoBehaviour
{
    public Animator agentAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            agentAnim.SetBool("findPlayer", true);
        }
    }
}
