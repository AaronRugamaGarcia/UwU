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
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(2);
        yield return null;
    }
}
