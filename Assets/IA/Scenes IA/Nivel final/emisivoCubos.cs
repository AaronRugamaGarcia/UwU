using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emisivoCubos : MonoBehaviour
{
    
    Color randomColor;
    
  

    void Start()
    {
        
        randomColor = new Color(Random.Range(0.5f, 0.7f), Random.Range(0.5f, 0.7f), Random.Range(0.5f, 0.7f));
        
        gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        gameObject.GetComponent<Renderer>().material.SetColor("_EMISSION",new Color(1.0f, 0.0f,0.0f,0.0f));

        //mater = new Material(Shader.Find("Standard"));
        //mr.material = mater;

    }

    void Update()
    {
        //mater.EnableKeyword("_EMISSION");
        //mater.SetColor("_EmissionColor", randomColor);

    }
}
