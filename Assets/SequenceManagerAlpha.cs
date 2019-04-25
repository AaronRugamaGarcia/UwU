using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceManagerAlpha : MonoBehaviour
{
    public GameObject Servers;
    public bool b_Servers;

    // Start is called before the first frame update
    void Start()
    {
        Servers.SetActive(true);
        //b_Servers = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) /*&& b_Servers == true*/)
        {
            Debug.Log("HOLI");
            Servers.SetActive(false);
            //b_Servers = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)/* && b_Servers == false*/)
        {

            Servers.SetActive(true);
            //b_Servers = true;
        }
    }
}
