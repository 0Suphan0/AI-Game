using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DamageControl : MonoBehaviour
{
    private float boxHealth = 3f;
    

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag=="agent")
        {
            boxHealth--;

            if (boxHealth==0)
            {
                Destroy(gameObject);
            }
        }


    }
    

}
