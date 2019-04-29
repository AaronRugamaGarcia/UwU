using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeOut_servers : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("TimeOutServers");
    }


    IEnumerator TimeOutServers()
    {
        yield return new WaitForSeconds(120f);
        SceneManager.LoadScene(1);
        yield return null;
    }
}
