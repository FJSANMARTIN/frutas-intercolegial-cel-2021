using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{


    public GameObject motorCintas;
    public motorCintas motorCintasScript;

    public Text textoTiempo;
    public float tiempo;

    public bool cronometroActivo;

    public Image masTiempo;
    void Start()
    {
        textoTiempo.text = "1:30";
        masTiempo.CrossFadeAlpha(0, 0, false);
    }

    
    void Update()
    {
        if(motorCintasScript.juegoTerminado == false && cronometroActivo == true)
        {
            tiempo -= Time.deltaTime;
            int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;

            textoTiempo.text = minutos.ToString() + ":" + segundos.ToString().PadLeft(2, '0');

        }

        if(tiempo <= 0.00f && motorCintasScript.juegoTerminado == false)
        {
            motorCintasScript.juegoTerminado = true;
            GameManager.instance.GameOver();
        }





    }



    public void ImagenMasTiempo()
    {
        masTiempo.CrossFadeAlpha(1, 0.5f, false);
        StartCoroutine(CierroImagenMasTiempo());
    }

    IEnumerator CierroImagenMasTiempo()
    {
        yield return new WaitForSeconds(1);
        masTiempo.CrossFadeAlpha(0, 0.5f, false);
    }
    
}
