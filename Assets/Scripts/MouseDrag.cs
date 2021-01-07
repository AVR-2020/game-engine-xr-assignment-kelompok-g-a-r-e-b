using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    //public Transform plane;
    public Camera cam;
    float distance = 0;

    private void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, cam.transform.position);
    }
    /*private void OnMouseUp()
    {
        if(Vector3.Distance(plane.position, transform.position) < 0)
        {
            transform.position = new Vector3(plane.position.x, plane.position.y + 2, plane.position.z);
        }
    }*/

    private void OnMouseDrag()
    {
        
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objectPos = cam.ScreenToWorldPoint(mousePos);

        transform.position = objectPos;
    }
}
