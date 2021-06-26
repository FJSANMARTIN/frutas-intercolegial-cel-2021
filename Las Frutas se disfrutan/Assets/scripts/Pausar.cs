using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pausar : MonoBehaviour
{
    public bool active;

   
    void Start()
    {
        
        
    }

   
    void Update()
    {
        
    }

    public void pausarJuego()
    {
        active = !active;
        
        Time.timeScale = (active) ? 0 : 1f;
    }
}
