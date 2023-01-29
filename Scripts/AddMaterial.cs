using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMaterial : MonoBehaviour
{
    public Material myMaterial;
    
    void Start()
    {
        GameObject Objects = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Objects.transform.position = new Vector3(12f, -3f, -82.5f);
        Objects.GetComponent<Renderer>().material = myMaterial;
    }
}
