using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelsName : MonoBehaviour
{
    public Text publicText;
    public string Name;
    public void showName()
    {
        PublicObject.activeModel = Name;
        publicText.text = Name;
        //Debug.Log(Name);
    }

    public void hideName()
    {
        PublicObject.activeModel = "No Object";
        publicText.text = "No Object";
        //Debug.Log(Name);
    }
}
