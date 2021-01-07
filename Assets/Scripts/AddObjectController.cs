using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObjectController : MonoBehaviour
{
    public GameObject KubusMenu;
    public GameObject BalokMenu;
    public GameObject TabungMenu;
    public GameObject LimasMenu;
    public GameObject BolaMenu;

    bool status = false;
    public void AddObjectMenu()
    {
        if(PublicObject.activeModel == "Kubus")
        {
            if (!status)
            {
                KubusMenu.SetActive(true);
                status = true;
            }
            else
            {
                KubusMenu.SetActive(false);
                status = false;
            }
        } 
        else if (PublicObject.activeModel == "Balok")
        {
            if (!status)
            {
                BalokMenu.SetActive(true);
                status = true;
            }
            else
            {
                BalokMenu.SetActive(false);
                status = false;
            }
        }
        else if (PublicObject.activeModel == "Tabung")
        {
            if (!status)
            {
                TabungMenu.SetActive(true);
                status = true;
            }
            else
            {
                TabungMenu.SetActive(false);
                status = false;
            }
        }
        else if (PublicObject.activeModel == "Limas")
        {
            if (!status)
            {
                LimasMenu.SetActive(true);
                status = true;
            }
            else
            {
                LimasMenu.SetActive(false);
                status = false;
            }
        }
        else if (PublicObject.activeModel == "Bola")
        {
            if (!status)
            {
                BolaMenu.SetActive(true);
                status = true;
            }
            else 
            {
                BolaMenu.SetActive(false);
                status = false;
            }
        }
    }

}
