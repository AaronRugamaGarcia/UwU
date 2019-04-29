using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emisivoCubos : MonoBehaviour
{
    Material mater;
    Color randomColor;
    MeshRenderer mr;
    void Start()
    {
        mr = gameObject.GetComponent<MeshRenderer>();
        mater = new Material(Shader.Find("Standard"));
        mr.material = mater;
        randomColor = new Color(Random.value, Random.value, Random.value);
    }

    void Update()
    {
        mater.EnableKeyword("_EMISSION");
        mater.SetColor("_EmissionColor", randomColor);

    }
}
