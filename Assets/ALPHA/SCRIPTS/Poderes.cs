using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poderes : MonoBehaviour
{
    public int poder;
    public Animator camAnimator;
    public Toggle dashToggle;
    public Toggle glitchToggle;
    public Toggle visionToggle;

    //Dash
    public GameObject indicador;
    public float pushPower = 0.05f;
    public CharacterController characterController;
    Vector3 forwardVector;
    public GameObject cam;
    public ParticleSystem Dash_VFX;
    public float Fov;
    bool b_dashIN;
    bool b_dashOUT;

    float max = 120.0f;
    float min = 60.0f;
    float fovIN_anim_duration = 4.0f;
    float fovOUT_anim_duration = 4.0f;
    float startTime;



    //Glitch
    Ray rayo;
    RaycastHit hit;
    public Material m_glitch;

    //VisionInter
    public Color color1 = Color.black;
    public GameObject[] interObj;
    public Camera camcam;

    public Material ObjetosInteractuables_V;
    public Material ObjetosInteractuables_NV;

    public Material ObjetosNOInteractuables_V;
    public Material ObjetosNOInteractuables_NV;




    static float t = 0.0f;



    private void Awake()
    {
        interObj = GameObject.FindGameObjectsWithTag("objInter");
    }

    void Start()
    {

        startTime = Time.time;


        cam = GameObject.Find("Main Camera");




        camAnimator = cam.GetComponent<Animator>();

        foreach (GameObject go in interObj)
        {
            go.SetActive(false);
        }
    }

    void Update()
    {



        //if(b_dashIN==true)
        //{



        //    float t = (Time.time - startTime) / fovIN_anim_duration;

        //    cam.gameObject.GetComponent<Camera>().fieldOfView = 120.0f;


        //    if (cam.gameObject.GetComponent<vp_FPCamera>().RenderingFieldOfView >= max)
        //    {
        //        b_dashOUT = true;
        //        b_dashIN = false;

        //    }
        //}
        //if(b_dashOUT==true)
        //{
        //    float t = (Time.time - startTime) / fovOUT_anim_duration;

        //    cam.gameObject.GetComponent<vp_FPCamera>().RenderingFieldOfView = Mathf.Lerp(max, min, t);

        //}




        if (Input.GetKey(KeyCode.Alpha1))
        {
            poder = 1;
            /*dashToggle.isOn = true;
            glitchToggle.isOn = false;
            visionToggle.isOn = false;*/
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            poder = 2;
            /*dashToggle.isOn = false;
            glitchToggle.isOn = true;
            visionToggle.isOn = false;*/
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            poder = 3;
            /*dashToggle.isOn = false;
            glitchToggle.isOn = false;
            visionToggle.isOn = true;*/
        }

        switch (poder)
        {
            case 1:
                forwardVector = camcam.transform.forward;

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    indicador.SetActive(true);
                }
                else
                {
                    indicador.SetActive(false);
                }

                if (Input.GetKeyUp(KeyCode.Q))
                {
                    StartCoroutine(Dash());


                }
                break;
            case 2:
                Vector3 forwardVector2 = cam.transform.forward * 8;
                rayo = new Ray(cam.transform.position, forwardVector2);
                Debug.DrawRay(cam.transform.position, forwardVector2, Color.green);

                if (Physics.Raycast(rayo, out hit) && hit.transform.gameObject.layer == 18 && Input.GetKeyUp(KeyCode.Q))
                {
                    hit.transform.gameObject.layer = 19;
                    //hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                    hit.transform.gameObject.GetComponent<Renderer>().material = m_glitch;
                    hit.transform.gameObject.GetComponent<ignoreCharacterControllerCollision>().enabled = true;
                }
                break;
            case 3:
                if (Input.GetKey(KeyCode.Q))
                {
                    camcam.clearFlags = CameraClearFlags.SolidColor;
                    camcam.backgroundColor = color1;

                    Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("Default"));
                    Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("NormalObject"));
                    Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("NoCollisionsObject"));
                    Camera.main.cullingMask &= ~(1 << LayerMask.NameToLayer("MovableObject"));

                    //indicador.GetComponentsInChildren<Renderer>().material = 
                    //añadir todas las layers, menos las de los object interactuables

                    foreach (GameObject go in interObj)
                    {
                        go.SetActive(true);
                    }
                }

                if (Input.GetKeyUp(KeyCode.Q))
                {
                    camcam.clearFlags = CameraClearFlags.Skybox;

                    Camera.main.cullingMask |= (1 << LayerMask.NameToLayer("Default"));
                    Camera.main.cullingMask |= (1 << LayerMask.NameToLayer("NormalObject"));
                    Camera.main.cullingMask |= (1 << LayerMask.NameToLayer("NoCollisionsObject"));
                    Camera.main.cullingMask |= (1 << LayerMask.NameToLayer("MovableObject"));
                    //añadir todas las layers, menos las de los object interactuables

                    foreach (GameObject go in interObj)
                    {
                        go.SetActive(false);
                    }
                }
                break;
        }
    }


    IEnumerator Dash()
    {

        b_dashIN = true;
        Dash_VFX.Play();




        //cam.gameObject.GetComponent<vp_FPCamera>().RenderingFieldOfView = 120;
        cam.gameObject.GetComponent<AudioSource>().Play();

        characterController.Move(forwardVector * pushPower);
        //camAnimator.Play("Fov", 0, 0.25f);

        indicador.SetActive(false);



        yield return new WaitForSeconds(.1f);
        //cam.gameObject.GetComponent<vp_FPCamera>().RenderingFieldOfView = Mathf.Lerp(max, min, 0.5f * Time.deltaTime);
        //cam.gameObject.GetComponent<vp_FPCamera>().RenderingFieldOfView = 60;
        Dash_VFX.Stop();

        b_dashIN = false;
    }
}
