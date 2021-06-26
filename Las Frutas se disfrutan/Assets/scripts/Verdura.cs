using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verdura : MonoBehaviour
{
    const int VerduraPoint = 2;

    public puntos Puntos;

    public Combos combos;

    private SpriteRenderer laVerdura;

    public GameObject verduraADestruir;
    void Start()
    {
        laVerdura = GetComponent<SpriteRenderer>();
    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D cInfo)
    {
        if (cInfo.gameObject.tag == "Player")
        {
            // el numero 10 significa que piso una verdura
            Puntos.AddPoints(10);


            combos.AddTemp(VerduraPoint);

            Destroy(verduraADestruir);


        }
    }
}
