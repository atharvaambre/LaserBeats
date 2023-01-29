using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastPointer : MonoBehaviour
{
  Ray ray;
  public float raylen = 100f; 
    Camera cam;
    [SerializeField] Transform Saber;
    [SerializeField] LineRenderer line;

    RaycastHit hitInfo;
    private void Start() {
        cam = Camera.main;
    }

    void Update()
    {
        
        Debug.DrawLine(this.transform.position,this.transform.position + this.transform.right,Color.green,raylen);
        // //Vector3 forward = transform.TransformDirection(Vector3.forward) * 30;
        // ray = cam.ScreenPointToRay(Input.mousePosition);
        // if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, 500)){
        //     line.enabled = true;
        //     line.SetPosition(0, Saber.transform.position);
        //     line.SetPosition(1, hitInfo.point);
        //     //Debug.DrawRay(transform.position,Vector3.forward, Color.green);
            
        //     Debug.Log("Hit:");
        // }
        // else
        //     Debug.Log("Hit Nothing");
        //     line.enabled = false;
    }
}
