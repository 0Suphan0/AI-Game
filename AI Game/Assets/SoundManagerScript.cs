using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip zombiSound, agentDeathSound;

     static AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        zombiSound = Resources.Load<AudioClip>("Zombie");
        agentDeathSound = Resources.Load<AudioClip>("AgentDeath");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Zombie":
                audioSource.PlayOneShot(zombiSound);
                break;

            case "AgentDeath":
                audioSource.PlayOneShot(agentDeathSound);
                break;

        }



    }
}
