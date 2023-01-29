using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMovement : MonoBehaviour
{
    float timer = 0f;
    [SerializeField]float speed = 1f;
    int phase = 0;
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (timer > 1f)
        {
            phase++;
            phase %= 4;            //Keep the phase between 0 to 3.
            timer = 0f;
        }

        switch (phase)
        {
            case 0:
                transform.Rotate(speed * (1 - timer),0f, 0f);  //Speed, from maximum to zero.
                break;
            case 1:
                transform.Rotate(-speed * timer,0f,0f);       //Speed, from zero to maximum.
                break;
            case 2:
                transform.Rotate(-speed * (1 - timer),0f,0f); //Speed, from maximum to zero.
                break;
            case 3:
                transform.Rotate(speed * timer,0f,0f);        //Speed, from zero to maximum.
                break;
        }
    }

}
