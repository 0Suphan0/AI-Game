using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Image = UnityEngine.UI.Image;

public class AgentControl : MonoBehaviour
{
    private NavMeshAgent myAgent;
    public GameObject target;
    public GameObject heatlhBar;
    

    public string agentType;
    private int agentHealth;
    private float agentDamage;

    void Start()
    {

        myAgent = GetComponent<NavMeshAgent>();

        myAgent.SetDestination(target.transform.position);

        switch (agentType)
        {
            case "Blue":
                agentHealth = 3;
                agentDamage = 8f;
                break;
            case "Yellow":
                agentHealth = 3;
                agentDamage = 12f;
                break;
            case "Green":
                agentHealth = 2;
                agentDamage = 16f;
                break;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            agentHealth--;

            if (agentHealth<=0)
            {
                SoundManagerScript.PlaySound("AgentDeath");
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("target"))
        {
            SoundManagerScript.PlaySound("Zombie");
            heatlhBar.GetComponent<Image>().fillAmount -= agentDamage / 100;
            target.GetComponent<TargetScript>().DecreaseHealth(agentDamage);
            Destroy(gameObject);
        }


    }



}