using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObject : MonoBehaviour
{
    public GameObject parent;
    public Camera cam;
    public GameObject obj;
    public void instanceNewObject()
    {
        GameObject nobj = Instantiate(obj, parent.transform.position, Quaternion.identity);
        nobj.transform.parent = parent.transform;
        nobj.GetComponent<MouseDrag>().cam = cam;
        nobj.tag = "Deleteable";

        if (parent.name == "Kubus")
        {
            nobj.layer = 8;
        }
        else if (parent.name == "Balok")
        {
            nobj.layer = 9;
        }
        else if (parent.name == "Tabung")
        {
            nobj.layer = 10;
        }
        else if (parent.name == "Limas")
        {
            nobj.layer = 11;
        }
        else if (parent.name == "Bola")
        {
            nobj.layer = 12;
        }
    }
}
