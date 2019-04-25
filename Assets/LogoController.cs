using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoController : MonoBehaviour
{


    private Rigidbody2D rb;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(100f, 100f);

        image = GetComponent<Image>();

        image.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }

    // Update is called once per frame
    void Update()
    {

        //if (this.transform.position.x >= 17f)
        //{
        //    this.transform.position = new Vector3(0f, 0f, 0f);
        //}
        //if (this.transform.position.x <= 17f)
        //{
        //    this.transform.position = new Vector3(0f, 0f, 0f);
        //}
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        image.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }

}