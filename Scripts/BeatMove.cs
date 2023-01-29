using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    //public Transform target;

    GameObject TowardsPlayer;
    void Start()
    {
        TowardsPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = transform.position;
        Vector3 b = TowardsPlayer.transform.position;
        transform.position = Vector3.Lerp(a, b, speed);

       
        
        /*transform.Translate(Vector3.right * speed * Time.deltaTime);
        Destroy(gameObject, 5f);*/
    }
}
