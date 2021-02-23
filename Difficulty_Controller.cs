using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//This code oversees the entire logic for part 3 of the assignment. This difficulty controller is a consistant item that tracks
//I wrote more direct notes on how it functions next to each line. This code is to be referenced by Hard_Mode_Enemy and Hard_Mode_Boss so that the difficulty changes.
// I did not end up modifying the player as I did not see the point in changing their stats for my game. 
//-Joseph Gage

public class Difficulty_Controller : MonoBehaviour
{
    public bool EasyMode = false;                                       //Variables are all made public for testing levels individually. Since the only level to have the difficulty controller is the hard/easy select,
    public bool HardMode = false;                                       // this allows for me to add the prefab into any level and test if both modes are working by manually changing variables in editor. 
    public Scene previousScene;


    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);                            //Prevents the gameObject from being destroyed and allows for it to be passed from level to level.
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "WinScene")               //Initially was going to be destroyed here, however; I changed it to the main menu instead. 
        {
 
        }
        else if (previousScene.name != SceneManager.GetActiveScene().name)  //This was a way to track to make sure that data is being tracked correctly.
        {
            previousScene = SceneManager.GetActiveScene();
            Debug.Log(previousScene.name);
        }
       
        else if (SceneManager.GetActiveScene().name == "IntroMenu")     //Code is destroyed when brought back to main menu. 
        {
            Destroy(this.gameObject);
        }

    }

    public void setDifficultyEasy()                             //Is this easy mode? Yupp, sets easy mode.
    {
        EasyMode = true;
        HardMode = false;
    }

     public void setDifficultyHard()                        //Sets hard mode. I did it for two booleans in case I wanted to add an extra mode. I did not end up doing so however
    {
        EasyMode = false;
        HardMode = true;
    }

   
}
