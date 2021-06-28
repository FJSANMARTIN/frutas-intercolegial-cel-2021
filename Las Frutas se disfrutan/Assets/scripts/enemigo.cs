using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public Vida vida;

    private void OnTriggerEnter2D(Collider2D info)
    {
        if (info.gameObject.CompareTag("Quita Vida"))
        {
            
            vida.loseHealth();
            
        }
    }



   



}
