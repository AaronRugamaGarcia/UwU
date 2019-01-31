using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    public float distanceToSee;

    Ray ray;
    RaycastHit hit;
    GameObject cam;
    private Raymarcher Fractals;

    public GameObject Servers_Room;
    public GameObject Fractals_Room;

    public Animator anim;


    public void Awake()
    {
        cam = GameObject.Find("Main Camera");
    }
    // Start is called before the first frame update
    void Start()
    {
        Fractals = GetComponent<Raymarcher>();

        Servers_Room.SetActive(true);
        Fractals_Room.SetActive(false);

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forwardVector = cam.transform.forward * 8;
        ray = new Ray(cam.transform.position, forwardVector);
        Debug.DrawRay(cam.transform.position, forwardVector, Color.red);


        if(Physics.Raycast(ray,out hit) && hit.transform.tag == "Server_1" && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("YEAH");
            
            hit.transform.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.green);
            anim.Play("PixelizerOn");

            Fractals.enabled = !Fractals.enabled;
            Servers_Room.SetActive(false);
            Fractals_Room.SetActive(true);
        }
    }
}
