using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public  float health;
    public GameObject gameOver;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
             gameOver.SetActive(true);
            
        }

      
    }

    public  void DecreaseHealth(float damage)
    {

        health -= damage;
    }


}
