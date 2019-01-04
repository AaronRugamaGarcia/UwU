using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject canvas;

    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            canvas.SetActive(true);
            Time.timeScale = 0.3f;
            GameObject.Find("Main Camera").GetComponent<vp_FPCamera>().enabled = false;
            GameObject.Find("Player").GetComponent<vp_FPController>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (!Input.GetKey(KeyCode.Tab))
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
            GameObject.Find("Main Camera").GetComponent<vp_FPCamera>().enabled = true;
            GameObject.Find("Player").GetComponent<vp_FPController>().enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
