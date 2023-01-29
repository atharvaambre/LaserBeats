using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSaberScore: MonoBehaviour
{

void OnTriggerEnter(Collider other) {
    if(other.name == "RedBeat(Clone)"){
        Scoresystem.scorevalue +=10;
    }
    else if(other.name == "BlueBeat(Clone)")
        Scoresystem.scorevalue -=10;
}

}



// void OnTriggerEnter(Collider other)
//     {
//         if(other.name=="BlueBeat")
//         {
//             transform.parent.GetComponent<Renderer>().material.color = Color.red;
//         }
//     }
//}

