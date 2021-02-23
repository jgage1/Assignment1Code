using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script contains the logic I used for creating the button. The player did not contain any character controllers, so I had to improvise. This code tracks the players x,z coordinate until it is within a 2 unit range of the button on any direction.
//I did it this way since adding in a box collider to the character messed up the logic with how it played. I also scripted a material change in the playerPressedButton function to show it has been activated.
//This script is referenced by the Door_Script.
//-Joseph Gage
public class ButtonScript : MonoBehaviour
{
    public GameObject player;
    float temp;

    bool firstValue = false;
    bool endLoop = false;
    public bool buttonPressed;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        buttonPressed = false; 

    }

    // Update is called once per frame
    void Update()
    {

        if (endLoop == false) { 

        for (int i = 0; i <= 20; i++)
            {

                temp = i / 10f;
               
                if (player.transform.position.x <= this.transform.position.x + temp && player.transform.position.x >= this.transform.position.x - temp)
                {
                    if ((player.transform.position.z <= this.transform.position.z + temp && player.transform.position.z >= this.transform.position.z - temp))
                    {
                        firstValue = true;
                        Debug.Log("FirstValue = True!");

                    }
                }


                if (firstValue == true)
                {
                    Debug.Log("Player is in button Range!!");
                    playerPressedButton();
                }


            }
        } 

      }


    private void playerPressedButton()
    {

        endLoop = true;
        Debug.Log("Button Has Been Pressed");
        buttonPressed = true;
        if (buttonPressed == true)
        {
            this.GetComponent<Renderer>().material.SetColor("_Color", Color.cyan);
        }
    }
}




