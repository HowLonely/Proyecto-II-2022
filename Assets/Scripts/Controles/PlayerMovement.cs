using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public PlayerControls controls;
    //Variables
    private Vector2 vector;
    public float Velocidad = 20;
    public float FuerzaDeSalto = 5;
    public Rigidbody2D rb;
    public Animator anim;


    //Checkeos para ver donde esta el Jugador
    private bool estaParado = false;
    private bool estaSaltando = false;
    private bool estaTocandoTecho = false;
    private bool estaTocandoPared = false;

    //Variables que tienen que ver con el salto de jugador
    public int maxSaltos = 1;
    public float gravedad = 1;
    private int contadorSaltos = 0;
    private Vector2 orientacion;

    private void Awake() {

        orientacion.x = transform.lossyScale.x;
        orientacion.y = transform.lossyScale.y;
        
        controls = new PlayerControls();
        controls.Enable();

        controls.Gameplay.MovimientoHorizontal.performed += ctx => {
            vector = ctx.ReadValue<Vector2>();
            MovimientoLateral();

        };

        controls.Gameplay.Saltar.performed += ctx => {
            Saltar();
        };

    }

    void MovimientoLateral() {
        rb.velocity = new Vector2(vector.x * Velocidad, rb.velocity.y);
        if(vector.x == -1)
            transform.localScale = new Vector2(orientacion.x * -1, orientacion.y);
        if(vector.x == 1)
            transform.localScale = new Vector2(orientacion.x, orientacion.y);

        anim.SetFloat("velocidad",Mathf.Abs(rb.velocity.x));
    }

    void Saltar() {
        //Si es que el jugador ya no puede saltar mas veces
        if(!estaParado && contadorSaltos >= maxSaltos)
            return;
        rb. velocity = new Vector2(rb.velocity.x, FuerzaDeSalto );
        estaParado = false;
        estaSaltando = true;
        contadorSaltos++;
        anim.SetBool("salto", estaSaltando);
    }


    void OnCollisionEnter2D(Collision2D collision){

        ContactPoint2D contact = collision.contacts[0];
        
        //Vector normal con respecto a la superficie que se esta tocando
        Vector2 normal = contact.normal;

        //Si la normal esta hacia arriba, el jugador esta parado en el piso
        estaParado = normal.y >= 0.1f;

        if(estaParado){
            contadorSaltos = 0; 
            estaSaltando = false;
            anim.SetBool("salto", estaSaltando);
        }

        //Si la normal apunta hacia abajo, el jugador esta tocando techo
        estaTocandoTecho = normal.y <= -0.1f;

        //Si la normal apunta a los lados, el jugador esta tocando una pared
        estaTocandoPared = Mathf.Abs(normal.x) > 0.1f;

    }
}
