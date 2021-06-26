using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Vida : MonoBehaviour
{
    const int initialHealth = 5;

    public int currentHealth;

    public Text vidaTxt;
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

        vidaTxt.text = currentHealth.ToString();
    }


    public void loseHealth()
    {
        currentHealth--;
    }
        
    

}
