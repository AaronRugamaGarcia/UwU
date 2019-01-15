using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingLaberinto : MonoBehaviour
{
    public GameObject player;
    public GameObject camLaberinto;
    public GameObject trigerLab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Conejo")
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
            player.SetActive(true);
            camLaberinto.SetActive(false);
            trigerLab.SetActive(false);
        }
    }
}
