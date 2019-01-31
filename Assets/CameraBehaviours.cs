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

    // Start is called before the first frame update
    void Start()
    {
        myCamera = GetComponent<Camera>();
        Fractals = GetComponent<Raymarcher>();

        i_rooms = 1;

        Servers_Room.SetActive(true);
        Fractals_Room.SetActive(false);

        

     
    }

    

    // Update is called once per frame
    void Update()
    {
        


        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            b_room = !b_room;
            
             if(b_room)
            {
                Fractals.enabled = !Fractals.enabled;
                Servers_Room.SetActive(false);
                Fractals_Room.SetActive(true);
            }
            else
            {
                Fractals.enabled = !Fractals.enabled;
                Servers_Room.SetActive(true);
                Fractals_Room.SetActive(false);
            }
            




        }

        




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
