using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTime : MonoBehaviour
{
    public GameObject CronometroGO;
    public Cronometro cronometroScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            cronometroScript.tiempo += 10;
            cronometroScript.ImagenMasTiempo();
            gameObject.SetActive(false);
        }
    }
}
