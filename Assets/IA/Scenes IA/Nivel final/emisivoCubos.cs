using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emisivoCubos : MonoBehaviour
{
    
    Color randomColor;
    Color red;
    Color green;
    Color blue;



    void Start()
    {
        Material ourMat = this.gameObject.GetComponent<Renderer>().material;
        //randomColor = new Color(Random.Range(0.5f, 0.7f), Random.Range(0.5f, 0.7f), Random.Range(0.5f, 0.7f));
        Color colorin = Random.ColorHSV(0.5f, 1.0f, 1.0f,1.0f,1f,1f,1f,1f);

        ourMat.EnableKeyword("_EMISSION");
        ourMat.SetColor("_EmissionColor", colorin);
        ourMat.SetColor("Color", colorin);
        
        //this.GetComponent<Renderer>().material.SetColor("_EMISSION", colorin);

        //mater = new Material(Shader.Find("Standard"));
        //mr.material = mater;

    }

    void Update()
    {
        //mater.EnableKeyword("_EMISSION");
        //mater.SetColor("_EmissionColor", randomColor);

    }
}
