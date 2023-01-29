using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField] float rotation_speed = 0f;
    public GameObject pivotpoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotpoint.transform.position,new Vector3(1,0,0), rotation_speed * Time.deltaTime);
    }
}
