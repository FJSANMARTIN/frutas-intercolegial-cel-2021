using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    const int initialHealth = 5;

    public int currentHealth;
    void Start()
    {
        currentHealth = initialHealth;
    }


    void Update()
    {
        if(currentHealth <= 0)
        {
            GameManager.instance.GameOver();
        }
    }


    public void loseHealth()
    {
        currentHealth--;
    }
        
    

}
