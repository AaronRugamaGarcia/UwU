using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreCharacterControllerCollision : MonoBehaviour
{
    CharacterController charCon;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        charCon = player.GetComponent<CharacterController>();
    }

    void Update()
    {
        Physics.IgnoreCollision(charCon, this.GetComponent<Collider>());
    }
}
