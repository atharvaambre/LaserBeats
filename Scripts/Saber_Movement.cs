using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber_Movement : MonoBehaviour
{
    GetTransform fetcher;
    public Quaternion obtained_rot;
    public Transform Laser;
    void Start()
    {
        fetcher = GetComponent<GetTransform>();
    }

    // Update is called once per frame
    void Update()
    {
       // obtained_rot = fetcher.saber_rotation;
        transform.rotation = obtained_rot;

       /* Laser = GameObject.Find("/ImageTarget_RedSaber");
        if (Laser != null)
        {
            obtained_rot  = fetcher.saber_rotation;
            transform.rotation = obtained_rot;
        }
        else
        {
            Debug.Log("The GameObject not initiated");
        }*/
    }
}
