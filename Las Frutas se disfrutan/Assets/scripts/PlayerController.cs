using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //se instancio la clase del controlador que configuramos del input system

    private ControladorPlayer controladorPlayer;

    private Rigidbody2D rb;

    private Collider2D col;

    [SerializeField] private float speed, jumpSpeed;
    [SerializeField] private LayerMask Ground;


   
    private void Awake()
    {
        // esto crea un objeto de la clse controladorPlayer
        controladorPlayer = new ControladorPlayer();
        //se extraen las propiedades del rigigbody

        rb = GetComponent<Rigidbody2D>();

        // se extraen los componentes del colider

        col = GetComponent<Collider2D>();

    }

    void Start()
    {

    }


    void Update()
    {

    }

    private void FixedUpdate()
    {


        //leer el valor del movimiento

        float movementInput = controladorPlayer.Normal.move.ReadValue<float>();



        //mover el player


        Vector3 currentPosition = transform.position;

        currentPosition.x += movementInput * speed * Time.deltaTime;

        transform.position = currentPosition;

        if (Isgrounded())
        {
            Jump();
        }

    }

    private void OnEnable()
    {
        controladorPlayer.Enable();
    }

    private void OnDisable()
    {
        controladorPlayer.Disable();
    }


    // se crea la funcion para saltar

    void Jump()
    {

        rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
    }

    bool Isgrounded()
    {
        Vector3 topLeftPoint = transform.position;
        topLeftPoint.x -= col.bounds.extents.x;
        topLeftPoint.y += col.bounds.extents.y;

        Vector3 bottomRight = transform.position;
        bottomRight.x += col.bounds.extents.x;
        bottomRight.y -= col.bounds.extents.y;

        return Physics2D.OverlapArea(topLeftPoint, bottomRight, Ground);
    }
}