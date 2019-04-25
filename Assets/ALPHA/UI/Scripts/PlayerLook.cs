using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity;

    float xAxisClamp = 0;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; //mantener el cursor en el centro de la pantalla
    }

    private void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        float mousex = Input.GetAxis("Mouse X");
        float mousey = Input.GetAxis("Mouse Y");

        float rotAmountX = mousex * mouseSensitivity;
        float rotAmountY = mousey * mouseSensitivity;

        xAxisClamp -= rotAmountY;

        Vector3 targetRotCam = transform.rotation.eulerAngles; 
        Vector3 targetRotBody = player.rotation.eulerAngles;

        targetRotCam.x -= rotAmountY;
        targetRotCam.z = 0;
        targetRotBody.y += rotAmountX;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 90;
            targetRotCam.x = 90;
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -90;
            targetRotCam.x = 270;
        }

        transform.rotation = Quaternion.Euler(targetRotCam);
        player.rotation = Quaternion.Euler(targetRotBody);
    }
}
