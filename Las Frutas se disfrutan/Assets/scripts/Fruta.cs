using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : MonoBehaviour
{
    const int frutaPoint = 1;

    public puntos Puntos;

    private SpriteRenderer laFruta;

    public Combos combos;

    public GameObject frutaADestruir;
    void Start()
    {
        laFruta = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D cInfo)
    {
        if (cInfo.gameObject.tag == "Player")
        {
            // el numero 11 significa que piso una verdura
            Puntos.AddPoints(11);


            combos.AddTemp(frutaPoint);

            
            Destroy(frutaADestruir);
           

        }
    }
}
