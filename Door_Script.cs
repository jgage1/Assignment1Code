using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script controls the door. Both buttons need to register as being pressed. They are set in editor as opposed to in code.
//Buttons are referenced in order to obtain the buttonPressed bool value and the door opens by turning off the box collider and mesh renderer in the object
//-Joseph Gage
public class Door_Script : MonoBehaviour
{

    public GameObject button1;
    public GameObject button2;
    bool doorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
    
    }


    // Update is called once per frame
    void Update()
    {
        if (doorOpen == false)
        {
            if (button1.GetComponent<ButtonScript>().buttonPressed == true && button2.GetComponent<ButtonScript>().buttonPressed == true)
            {
                Debug.Log("Button Pressed, Opening Door");

                this.gameObject.GetComponent<MeshRenderer>().enabled = false;
                this.gameObject.GetComponent<BoxCollider>().enabled = false;

                doorOpen = true;

            }
        }
    }
}
