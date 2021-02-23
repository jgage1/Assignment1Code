using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject DifficultyController;
    public bool temp;
    public bool temp1;
    public int mode;
    public GameObject EnemyHoverBot;

    private Vector3 WorldLocation;

   
    // Start is called before the first frame update
    void Start()
    {
      DifficultyController = GameObject.Find("Difficulty_Controller_OBJ");
        DifficultyController.GetComponent<Difficulty_Controller>();
        temp = DifficultyController.GetComponent<Difficulty_Controller>().EasyMode;       //Referencing Difficulty_Controller variables
        temp1= DifficultyController.GetComponent<Difficulty_Controller>().HardMode;
        evaluateMode(temp, temp1);


        WorldLocation = transform.TransformPoint(Vector3.zero);
        EnemySpawn();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void evaluateMode(bool x, bool y)                                                    //This function is just to attempt to make sure that referenced variables from another script store correctly. Logic check. 
    {
        if(x == true && y == false) { mode = 1; } //Easy Mode Activated
        else if (x == false && y == true) { mode = 2; } //Hard Mode Activated
    }

    void EnemySpawn()                                                                     //Spawns different enemy counts depending on mode that is selected 
    {
        if(mode == 1)
        {
            Instantiate(EnemyHoverBot, WorldLocation, Quaternion.identity);
        }
        else if (mode == 2)
        {
            Instantiate(EnemyHoverBot, new Vector3(WorldLocation.x, WorldLocation.y, WorldLocation.z + 1), Quaternion.identity);
            Instantiate(EnemyHoverBot, WorldLocation, Quaternion.identity);
        }
    }

}
