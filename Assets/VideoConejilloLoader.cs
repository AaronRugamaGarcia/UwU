using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoConejilloLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Loader");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Loader()
    {

        yield return new WaitForSeconds(32.0f);
        SceneManager.LoadScene(5);
        yield return null;
    }
}
