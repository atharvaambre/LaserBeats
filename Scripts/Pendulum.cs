using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    Rigidbody rb;

    public float moveSpeed;
    public float leftAngle;
    public float rightAngle;

    bool movingClockwise;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movingClockwise = true;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void ChangeMoveDir()
    {
        if (rb.transform.rotation.x > rightAngle)
        {
            movingClockwise = false;
        }
        if (rb.transform.rotation.x < leftAngle)
        {
            movingClockwise = true;
        }

    }

    public void Move()
    {
        ChangeMoveDir();

        if (movingClockwise)
        {
            rb.transform.Rotate(Vector3.right, moveSpeed * Time.deltaTime);
            Debug.Log("I am true statement getting executed");
        }

        if (!movingClockwise)
        {
            rb.transform.Rotate(Vector3.left, moveSpeed * Time.deltaTime);
            Debug.Log("I am false statement getting executed");
        }
    }
}
