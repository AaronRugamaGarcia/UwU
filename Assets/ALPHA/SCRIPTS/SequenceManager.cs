using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SequenceManager : MonoBehaviour
{
    public GameObject player;
    public GameObject playerCamera;
    public Raymarcher fractal;

    public Scene Sc_Scene0;
    public string s_Scene0 = "Servers";
    public bool b_Scene0;

    public Scene Sc_Scene1;
    public string s_Scene1 = "Shaders_Scene";
    public bool b_Scene1;

    public Scene Sc_Scene2;
    public string s_Scene2 = "Tokyo";
    public bool b_Scene2;

    public Scene Sc_Scene3;
    public string s_Scene3 = "Oficine";
    public bool b_Scene3;

    private void Awake()
    {
        fractal = playerCamera.GetComponent<Raymarcher>();
        
    }

    //START::::::::::::::::::::::::::::::::::
    private void Start()
    {


        //b_Scene0 = true;
        //b_Scene1 = false;
        //b_Scene2 = false;
        //b_Scene3 = false;
        //player.GetComponent<Raymarcher>().enabled = false;
        StartCoroutine(LoadSceneAndSetActive0());
        fractal.enabled = false;


        //StartCoroutine(UnloadSceneAndSetActive1());
        //StartCoroutine(UnloadSceneAndSetActive2());
        //StartCoroutine(UnloadSceneAndSetActive3());
    }

   
    //INPUTS::::::::::::::::::::::::::::::::::::::
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            //b_Scene0 = true;
            //b_Scene1 = false;
            //b_Scene2 = false;
            //b_Scene3 = false;
            StartCoroutine(LoadSceneAndSetActive1());
            fractal.enabled = true;


            StartCoroutine(UnloadSceneAndSetActive0());
            //StartCoroutine(UnloadSceneAndSetActive2());
            //StartCoroutine(UnloadSceneAndSetActive3());


        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            b_Scene0 = false;
            b_Scene1 = true;
            b_Scene2 = false;
            b_Scene3 = false;
            StartCoroutine(UnloadSceneAndSetActive2());




            StartCoroutine(UnloadSceneAndSetActive0());
            StartCoroutine(UnloadSceneAndSetActive2());
            StartCoroutine(UnloadSceneAndSetActive3());

        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && !b_Scene2)
        {

            b_Scene0 = false;
            b_Scene1 = false;
            b_Scene2 = true;
            b_Scene3 = false;
            StartCoroutine(LoadSceneAndSetActive2());



            StartCoroutine(UnloadSceneAndSetActive0());
            StartCoroutine(UnloadSceneAndSetActive1());
            StartCoroutine(UnloadSceneAndSetActive3());


        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && !b_Scene3)
        {

            b_Scene0 = false;
            b_Scene1 = false;
            b_Scene2 = false;
            b_Scene3 = true;
            StartCoroutine(LoadSceneAndSetActive3());



            StartCoroutine(UnloadSceneAndSetActive0());
            StartCoroutine(UnloadSceneAndSetActive2());
            StartCoroutine(UnloadSceneAndSetActive1());

        }

    }





    //LOAD SCENES:::::::::::::::::::::::::::::::::::::::::::::::::::::::
    IEnumerator LoadSceneAndSetActive0()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(("Servers"), LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator LoadSceneAndSetActive1()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(("Shaders_Scene"), LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator LoadSceneAndSetActive2()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(("Tokyo"), LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator LoadSceneAndSetActive3()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(("Oficine"), LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }





    //UNLOAD SCENES:::::::::::::::::::::::::::::::::::::::::::::: 
    IEnumerator UnloadSceneAndSetActive0()
    {

        AsyncOperation asyncLoad = SceneManager.UnloadSceneAsync("Servers");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator UnloadSceneAndSetActive1()
    {

        AsyncOperation asyncLoad = SceneManager.UnloadSceneAsync("Shaders_Scene");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator UnloadSceneAndSetActive2()
    {

        AsyncOperation asyncLoad = SceneManager.UnloadSceneAsync("Tokyo");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator UnloadSceneAndSetActive3()
    {

        AsyncOperation asyncLoad = SceneManager.UnloadSceneAsync("Officine");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
