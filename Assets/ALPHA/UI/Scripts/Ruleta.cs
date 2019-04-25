using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruleta : MonoBehaviour
{
    private SpriteRenderer sRenderer;

    void Start()
    {
        sRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
    }

    public void ChangeColor()
    {
        sRenderer.color = new Color(0f, 0f, 0f, 1f);
    }

    public void ChangeColor2()
    {
        sRenderer.color = new Color(0f, 1f, 0f, 0f);
    }
}
