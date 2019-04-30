using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeOut_apartments : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine("TimeOutApartments");
    }

    
    IEnumerator TimeOutApartments()
    {
        yield return new WaitForSeconds(60f);
        SceneManager.LoadScene(2);
        yield return null;
    }
}
