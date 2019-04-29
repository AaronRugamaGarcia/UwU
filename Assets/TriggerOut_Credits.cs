using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerOut_Credits : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("TimeOutCredits");
    }


    IEnumerator TimeOutCredits()
    {
        yield return new WaitForSeconds(16f);
        SceneManager.LoadScene(8);
        yield return null;
    }
}