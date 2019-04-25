using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLaberinto : MonoBehaviour
{
    public GameObject player;
    public GameObject camLaberinto;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            player.SetActive(false);
            camLaberinto.SetActive(true);
        }
    }
}
