using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject canvas;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            canvas.SetActive(true);
            Time.timeScale = 0.3f;
            GameObject.Find("Main Camera").GetComponent<PlayerLook>().enabled = false;
            GameObject.Find("Player").GetComponent<PlayerMove>().enabled = false;
            //Cursor.lockState = CursorLockMode.Locked;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (!Input.GetKey(KeyCode.Tab))
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
            GameObject.Find("Main Camera").GetComponent<PlayerLook>().enabled = true;
            GameObject.Find("Player").GetComponent<PlayerMove>().enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
