using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Pausar pausa;

    public motorCintas elMotorCintas;

    public bool Ingame;
    public bool gameOver;
    public bool pauseGame;

    private void Awake()
    {
        instance = this;

    }
    private void Start()
    {
        elMotorCintas.cuentaRegresivaTermino = true;
        InGame();

        
    }
    private void Update()
    {
        //TO DO: despues cambiaremos a button, el space es provisorio
        if (Input.GetKeyDown("space") && gameOver == false)
        {
            PauseGame();
        }

        if(pausa.active == false && gameOver == false)
        {
            
            InGame();
        }
        //TO DO: Cuando el personaje se quede sin vidas, o sin tiempo, desde esas
        //mecanicas independientes cambiaran el estado de la variable gameOver

       
        if (gameOver == true)
        {
            GameOver();
        }
    }
    private void InGame()
    {
        Ingame = true;
        pauseGame = false;
        gameOver = false;




        Debug.Log("El juego esta en modo inGame");
    }


    private void PauseGame()
    {
        pausa.pausarJuego();
        pauseGame = true;
        Ingame = false;
        gameOver = false;
        Debug.Log("El juego esta en modo Pausa");
        
    }

    /*TO DO:
      *Hacer el Game Over canvas
      *Hacer el ingame Canvas
      *Hacer el pause Canvas
     */
    public void GameOver()
    {
        pauseGame = false;
        Ingame = false;
        gameOver = true;

        elMotorCintas.juegoTerminado = true;
        Debug.Log("El juego esta en modo GameOver");
        
    }








}
