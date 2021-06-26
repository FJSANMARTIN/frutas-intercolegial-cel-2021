using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motorCintas : MonoBehaviour
{
    public GameObject MotorCintas;


    //contiene los prefabs de las cintas
    public GameObject[] contenedorCintas;

    public float speed = 5;

    //numero que sirve para seleccionar la cinta en aleatorio (opcional)
    public int numeroSelectorDeCintas;

    //contador de cintas instanciadas
    public int numeroContadorCintas = 0;


    //condiciones para saber si el motor debe empezar a funcionar

    public bool cuentaRegresivaTermino;

    public bool juegoTerminado;


    void Start()
    {
        
        Iniciar();
    }

    public void Iniciar()
    {
        
        
        CreaCintas();
 
        SpeedNormal();
        


    }

    void Update()
    {
        if (numeroContadorCintas >= 10 && numeroContadorCintas <= 19)
        {
            IncreaseSpeedLevel1();
        }

        if (numeroContadorCintas >= 20)
        {
            IncreaseSpeedLevel2();
        }

        if(juegoTerminado == true)
        {
            FinalizarJuego();
            
        }
    }

    private void FixedUpdate()
    {

        if (cuentaRegresivaTermino == true && juegoTerminado == false)
        {
            MotorCintas.transform.Translate(Vector3.left * speed * Time.deltaTime);

        }


    }

    //esta funcion crea las cintas una detras de otra
    public void CreaCintas()
    {

        numeroSelectorDeCintas = Random.Range(0, 3);

        GameObject Cinta = (GameObject)Instantiate(contenedorCintas[numeroSelectorDeCintas],
                                                        new Vector3(17,0,0) , transform.rotation);       

        Cinta.SetActive(true);
        numeroContadorCintas++;

       

        Cinta.name = "Cinta"+numeroContadorCintas;


        Cinta.transform.parent = MotorCintas.transform;


        GameObject piezaAux = GameObject.Find("Cinta"+(numeroContadorCintas - 1));

        

        Cinta.transform.position = new Vector3(piezaAux.GetComponent<Renderer>().bounds.size.x +
                                                 piezaAux.transform.position.x, transform.position.y + -4,
                                                 transform.position.z);







    }





    public void SpeedNormal()

    {
      
        speed = 2.5f;
       
    }

    public void StopSpeed()
    {
        speed = 0;

    }

    //se aumentara la velocidad si el contador de carreteras ya va por el 10
    public void IncreaseSpeedLevel1()
    {
        speed = 3;

    }
    //se aumentara la velocidad si el contador de carreteras ya va por el 20
    
    public void IncreaseSpeedLevel2()
    {
        speed = 3.5f;
    }

    public void FinalizarJuego()
    {
        StopSpeed();
    }











}

