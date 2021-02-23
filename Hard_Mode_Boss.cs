using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard_Mode_Boss : MonoBehaviour
{
    public GameObject DifficultyController;
    public float NewMaxHealth;
    public float NewDropRate;

    private GameObject Enemy;

    //This code controls the hard mode settings for the boss. I made it seperate from the Hard_Mode_Enemy code in case there were other parameters I wanted to modify. I ended up keeping them the same at the end though,
    //-Joseph Gage

    // Start is called before the first frame update
    void Start()
    {
        DifficultyController = GameObject.Find("Difficulty_Controller_OBJ");
        DifficultyController.GetComponent<Difficulty_Controller>();
        Enemy = this.gameObject;

        if (DifficultyController.GetComponent<Difficulty_Controller>().HardMode == true)
        {

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