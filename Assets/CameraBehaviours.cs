using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviours : MonoBehaviour
{

    private Camera myCamera;
    private Raymarcher Fractals;

    public GameObject Servers_Room;
    public GameObject Fractals_Room;


    public int i_rooms;
    public bool b_room;

    public Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        myCamera = GetComponent<Camera>();
        Fractals = GetComponent<Raymarcher>();

        i_rooms = 1;

        Servers_Room.SetActive(true);
        Fractals_Room.SetActive(false);

        anim = GetComponent<Animator>();


        StartCoroutine("Changeroom2");
    }

    

    // Update is called once per frame
    void Update()
    {
        


        //if(Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    b_room = !b_room;
            
        //     if(b_room)
        //    {
        //        anim.Play("PixelizerOn");

        //        Fractals.enabled = !Fractals.enabled;
        //        Servers_Room.SetActive(false);
        //        Fractals_Room.SetActive(true);
        //    }
        //    else
        //    {
        //        anim.Play("PixelizerOn");
        //        Fractals.enabled = !Fractals.enabled;
        //        Servers_Room.SetActive(true);
        //        Fractals_Room.SetActive(false);
        //    }
            




        //}

        




    }
    IEnumerator Changeroom1()
    {
        yield return new WaitForSeconds(5.0f);
        anim.Play("PixelizerOn");
        Fractals.enabled = true;
        //Fractals.enabled = !Fractals.enabled;
        Servers_Room.SetActive(false);
        Fractals_Room.SetActive(true);

        StartCoroutine("Changeroom2");
    }

    IEnumerator Changeroom2()
    {
        yield return new WaitForSeconds(5.0f);
        anim.Play("PixelizerOn");
        Fractals.enabled = true;
        //Fractals.enabled = !Fractals.enabled;
        Servers_Room.SetActive(true);
        Fractals_Room.SetActive(false);

        StartCoroutine("Changeroom1");
    }


    //void roomsChange()
    //{
    //    switch (i_rooms)
    //    {
    //        case 0:
    //            Fractals.enabled = !Fractals.enabled;
    //            Servers_Room.SetActive(false);
    //            Fractals_Room.SetActive(true);
    //            break;

    //        case 1:
    //            Fractals.enabled = !Fractals.enabled;
    //            Servers_Room.SetActive(true);
    //            Fractals_Room.SetActive(false);
    //            break;

    //        default:
    //            Debug.Log("Default State");
    //            break;
    //    }

    //}
}
