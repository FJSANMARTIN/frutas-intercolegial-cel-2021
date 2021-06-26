using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cuentaAtras : MonoBehaviour
{

    public GameObject motorCinta;
    public GameObject numeros;
    public Sprite[] numerosImg;


    public motorCintas motorCintasScript;
    public Cronometro cronometroScript;

    float tiempoEspera = 4;

    public bool pararCuenta = false;
    public bool finContador = false;

    void Start()
    {
        CuentaAtras();
    }

    
    void Update()
    {
        if(tiempoEspera == 0 && pararCuenta == false)
        {
            pararCuenta = true;
            numeros.SetActive(false);
        }
    }

    public void CuentaAtras()
    {
        StartCoroutine(EmpezarCuentaAtras());

         
    }
    public IEnumerator EmpezarCuentaAtras()
    {
        yield return new WaitForSeconds(1);
        InvokeRepeating("Contando", 1.0f, 1.0f);
    }

    public void Contando()
    {
        tiempoEspera--;

        if(tiempoEspera >= 3)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosImg[3];
        }

        if (tiempoEspera <= 3 && tiempoEspera >=2)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosImg[2];
        }
        if (tiempoEspera <= 2 && tiempoEspera >= 1)
        {
            numeros.GetComponent<SpriteRenderer>().sprite = numerosImg[1];
        }


        if (tiempoEspera <= 1 && finContador == false)
        {
            finContador = true;
            cronometroScript.cronometroActivo = true;
            motorCintasScript.cuentaRegresivaTermino = true;
            numeros.GetComponent<SpriteRenderer>().sprite = numerosImg[0];
        }


        if(tiempoEspera <= 0)
        {
            CancelInvoke();
        }



    }

}
