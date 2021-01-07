using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Transform refPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    GameObject[] FindGameObjectsInLayer(int layer)
    {
        var goArray = FindObjectsOfType(typeof(GameObject)) as GameObject[];
        var goList = new System.Collections.Generic.List<GameObject>();
        for (int i = 0; i < goArray.Length; i++)
        {
            if (goArray[i].layer == layer)
            {
                goList.Add(goArray[i]);
            }
        }
        if (goList.Count == 0)
        {
            return null;
        }
        return goList.ToArray();
    }

    // Update is called once per frame
    void Update()
    {
        /*GameObject[] objs = FindGameObjectsInLayer(8);
        //normal = filter.mesh.normals[0];

        foreach (var obj in objs)
        {
            if(obj.activeSelf == true)
            {
                Vector3 toTarget = (obj.transform.position - transform.position).normalized;

                if (Vector3.Dot(toTarget, transform.up) < 0)
                {
                    //Debug.Log("Target is in front of this game object.");
                    obj.transform.position = refPos.position + refPos.up;

                }
            }
            
        }*/
        
    }
}
