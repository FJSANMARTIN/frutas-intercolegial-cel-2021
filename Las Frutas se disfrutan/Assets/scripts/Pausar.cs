using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pausar : MonoBehaviour
{
    public bool active;
    public Canvas canvas;
   
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

   
    void Update()
    {
        
    }

    public void pausarJuego()
    {
        active = !active;
        canvas.enabled = active;
        Time.timeScale = (active) ? 0 : 1f;
    }
}
