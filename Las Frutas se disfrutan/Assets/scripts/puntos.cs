using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos : MonoBehaviour
{
    public GameObject  puntosNivel;

    

    public int currentPoints;

    public int winPoints;
    void Start()
    {
        if (puntosNivel.name == "Tutorial")
        {
            
            winPoints = 25;
        }

        if (puntosNivel.name == "Nivel1")
        {
           
            winPoints = 50;
        }

        if (puntosNivel.name == "Nivel2")
        {
           
            winPoints = 150;
        }

        if (puntosNivel.name == "Nivel3")
        {
            
            winPoints = 300;
        }

        currentPoints = 0;
    }

   
    void Update()
    {
        if (currentPoints >= winPoints)
        {
            GameManager.instance.winGame();
        }
    }

    public int AddPoints(int combo)
    {
        

        if(currentPoints < winPoints)
        {
          if(combo == 1)
          {
                currentPoints = currentPoints + 10;
                Debug.Log("Se realizo el combo 1 y se te sumaron 10 puntos");
          }

          if (combo == 2)
          {
                currentPoints = currentPoints + 10;
                Debug.Log("Se realizo el combo 2 y se te sumaron 10 puntos");
            }

          if(combo == 3)
          {
                currentPoints = currentPoints + 5;
                Debug.Log("Se realizo el combo 3 y se te sumaron 5 puntos");
            }
          if (combo == 4)
          {
                currentPoints = currentPoints + 5;
                Debug.Log("Se realizo el combo 4 y se te sumaron 5 puntos");
            }
          if (combo == 5)
          {
                currentPoints = currentPoints + 2;
                Debug.Log("Se realizo el combo 5 y se te sumaron 2 puntos");
            }
          if (combo == 6)
          {
                currentPoints = currentPoints + 2;
                Debug.Log("Se realizo el combo 6 y se te sumaron 2 puntos");
            }

          if(combo == 10)
            {
                currentPoints++;
                Debug.Log("Comiste una verdura");
            }
          if (combo == 11)
          {
                currentPoints++;
                Debug.Log("comiste una fruta");
          }
        }


        return 0;
    }
}
