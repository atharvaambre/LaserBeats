using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceOnAxis : MonoBehaviour
{
    public Rigidbody rigidbody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if(transform.rotation.x > 25)   
        rigidbody.AddForce(-25, 0, 0);
     else if(transform.rotation.x < 25)
        rigidbody.AddForce(25, 0, 0);
    }
}
