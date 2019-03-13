using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleBuzones : MonoBehaviour
{
    Ray rayo;
    RaycastHit hit;
    public GameObject cam;
    public GameObject direccion1; public GameObject luz1; public GameObject mail1;
    public GameObject direccion2; public GameObject luz2; public GameObject mail2;
    public GameObject direccion3; public GameObject luz3; public GameObject mail3;
    public Material notmail;    

    private void Awake()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Start()
    {

    }

    void Update()
    {
        Vector3 forwardVector2 = cam.transform.forward * 5;
        rayo = new Ray(cam.transform.position, forwardVector2);
        Debug.DrawRay(cam.transform.position, forwardVector2, Color.red);

        if (Physics.Raycast(rayo, out hit) && hit.transform.gameObject.tag == "Mail")
        {
            if (Input.GetKey(KeyCode.E) && hit.transform.gameObject.name == "Mail1")
            {
                direccion1.SetActive(true); luz1.SetActive(true);
                direccion2.SetActive(false); luz2.SetActive(false);
                direccion3.SetActive(false); luz3.SetActive(false);
            }
            else if (Input.GetKey(KeyCode.E) && hit.transform.gameObject.name == "Mail2")
            {
                direccion1.SetActive(false); luz1.SetActive(false);
                direccion2.SetActive(true); luz2.SetActive(true);
                direccion3.SetActive(false); luz3.SetActive(false);
            }
            else if (Input.GetKey(KeyCode.E) && hit.transform.gameObject.name == "Mail3")
            {
                direccion1.SetActive(false); luz1.SetActive(false);
                direccion2.SetActive(false); luz2.SetActive(false);
                direccion3.SetActive(true); luz3.SetActive(true);
            }
        }

        if (Physics.Raycast(rayo, out hit) && hit.transform.gameObject.tag == "MailLuz")
        {
            if (Input.GetKey(KeyCode.E) && hit.transform.gameObject.name == "MailLuz1")
            {
                direccion1.SetActive(false);
                luz1.SetActive(false);
                mail1.GetComponent<MeshRenderer>().material = notmail;
            }
            else if (Input.GetKey(KeyCode.E) && hit.transform.gameObject.name == "MailLuz2")
            {
                direccion2.SetActive(false);
                luz2.SetActive(false);
                mail2.GetComponent<MeshRenderer>().material = notmail;
            }
            else if (Input.GetKey(KeyCode.E) && hit.transform.gameObject.name == "MailLuz3")
            {
                direccion3.SetActive(false);
                luz3.SetActive(false);
                mail3.GetComponent<MeshRenderer>().material = notmail;
            }
        }
    }
}
