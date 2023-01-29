using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTransform : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    [SerializeField]Rigidbody rb;
    public float speed;

    
    //public Vector3 cube_position;
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        //transform.rotation = target.rotation;
        //transform.eulerAngles.x = target.eulerAngles.x;

        Vector3 a = transform.position;
        Vector3 b = target2.position;

        transform.eulerAngles = new Vector3(target.transform.eulerAngles.x ,target.transform.eulerAngles.y,target.transform.eulerAngles.z);
        if(transform.eulerAngles.x > 0) 
        {
            transform.position = Vector3.MoveTowards(a, b, speed); 
        }
    }
}
