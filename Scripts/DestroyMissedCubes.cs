using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMissedCubes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
 private void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.tag == "Beats")
        {
          Destroy(collision.gameObject);
          Scoresystem.missesvalue +=1;
        } 

   }
    void Update()
    {
    
    }
}
