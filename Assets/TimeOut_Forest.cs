using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeOut_Forest : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("TimeOutForest");
    }


    IEnumerator TimeOutForest()
    {
        yield return new WaitForSeconds(60f);
        SceneManager.LoadScene(7);
        yield return null;
    }
}
