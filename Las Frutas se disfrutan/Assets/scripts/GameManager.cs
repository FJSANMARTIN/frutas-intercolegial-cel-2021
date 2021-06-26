using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Pausar pausa;

    public motorCintas elMotorCintas;

    public Canvas inGameCanvas;
    public Canvas pauseCanvas;
    public Canvas gameOverCanvas;
    public Canvas winCanvas;

    public bool Ingame;
    public bool gameOver;
    public bool pauseGame;
    public bool winnGame;

    public GameObject personaje;
    private void Awake()
    {
        instance = this;

    }
    private void Start()
    {
         

        
        InGame();

        
    }
    private void Update()
    {
        

        if(pausa.active == false && gameOver == false && winnGame == false)
        {
            
            InGame();
        }
    

       

    }
    private void InGame()
    {
        Ingame = true;
        pauseGame = false;
        gameOver = false;

        pauseCanvas.enabled = false;
        gameOverCanvas.enabled = false;
        winCanvas.enabled = false;
        inGameCanvas.enabled = true;
        



        
    }


    public void PauseGame()
    {
        pausa.pausarJuego();
        pauseGame = true;
        Ingame = false;
        gameOver = false;

        pauseCanvas.enabled = true;
        gameOverCanvas.enabled = false;
        winCanvas.enabled = false;
        inGameCanvas.enabled = false;
    }

    
    public void GameOver()
    {
        pauseGame = false;
        Ingame = false;
        gameOver = true;

        elMotorCintas.juegoTerminado = true;

        pauseCanvas.enabled = false;
        gameOverCanvas.enabled = true;
        winCanvas.enabled = false;
        inGameCanvas.enabled = false;

        pausa.pausarJuego();
        Destroy(personaje);
    }


    public void winGame()
    {
        pauseGame = false;
        Ingame = false;
        gameOver = false;
        winnGame = true;

        elMotorCintas.juegoTerminado = true;

        pauseCanvas.enabled = false;
        gameOverCanvas.enabled = false;
        winCanvas.enabled = true;
        inGameCanvas.enabled = false;

        pausa.pausarJuego();
        
        Destroy(personaje);

    }


   //funcion para reiniciar el nivel
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level1");
        PauseGame();
    }

}
