using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjeto : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject prefab;
   
    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Maze")
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                prefab.transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            }
        }
    }
}
