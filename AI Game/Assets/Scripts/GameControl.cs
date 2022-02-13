using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public GameObject[] SpawnPoints;

    public GameObject InstObject;

    public Text myText;

    public Button[] myButtons;

    private int counter = 30;

   
    void Start()
    {

        myText.text = counter.ToString();
        
    }

    
    void Update()
    {
        
    }



     public  void BtnClick(int value)
     {

         Instantiate(InstObject, SpawnPoints[value].transform.position, Quaternion.identity);
         counter--;
         myText.text = counter.ToString();

         if (counter==0)
         {
             foreach (var button in myButtons)
             {
                 button.interactable = false;
             }

         }

     }




}
