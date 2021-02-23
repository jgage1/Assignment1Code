using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This code controls how hard mode is done for the hover_bots in the game. 
//It references the difficulty controller in order to obtain if the game is running in easy or hard mode. The difficulty controller is a the constant object in the scene that tracks the mode.
//After references to the controller are created, I then obtain references to the values I wished to modify on the enemy. I then set their values in editor so as to have more control in fine tuning their values. 
//-Joseph Gage

public class Hard_Mode_Enemy : MonoBehaviour
{
    public GameObject DifficultyController;
    public float NewMaxHealth;
    public float NewDropRate;

    private GameObject Enemy;



    // Start is called before the first frame update
    void Start()
    {
        DifficultyController = GameObject.Find("Difficulty_Controller_OBJ");
        DifficultyController.GetComponent<Difficulty_Controller>();
        Enemy = this.gameObject;

        if (DifficultyController.GetComponent<Difficulty_Controller>().HardMode == true) {

            Enemy.GetComponent<Health>().maxHealth = NewMaxHealth;
            Enemy.GetComponent<Health>().currentHealth = NewMaxHealth;

            Enemy.GetComponent<EnemyController>().dropRate = NewDropRate;

        }
        Debug.Log(Enemy.GetComponent<Health>().currentHealth);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
