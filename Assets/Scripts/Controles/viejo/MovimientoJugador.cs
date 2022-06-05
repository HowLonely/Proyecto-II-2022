using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    //Variables
    public float Velocidad = 5f;
    public float FuerzaDeSalto = 5f;
    private Rigidbody2D RigidBody;
    public Animator animator;

    //Checkeos para ver donde esta el Jugador
    private bool estaParado = false;
    private bool estaSaltando = false;
    private bool estaTocandoTecho = false;
    private bool estaTocandoPared = false;

    private bool estaAtacando = false;
    //Variables que tienen que ver con el salto de jugador
    public int maxSaltos = 1;
    public float gravedad = 1;
    private int contadorSaltos = 0;

    //Al iniciar el juego
    void Awake() {
        RigidBody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        //Si se presiona el espacio
        if (Input.GetKeyDown(KeyCode.Space))
            Saltar();
            //Si se presiona S mientras se salta, el jugador cae mas rapido
            if (Input.GetKeyDown(KeyCode.S))
                RigidBody.velocity = Vector2.down * gravedad * FuerzaDeSalto;
        
        //Si se presiona A o D, el personaje se movera a los lados
        //Si es la A, se movera a la izquierda y tendra un valor negativo
        //Si es la D, derecha y positivo

        float direccion = 0;
        if(Input.GetKey(KeyCode.A)) 
            direccion = -1f;
        if(Input.GetKey(KeyCode.D)) 
            direccion = 1f;

        RigidBody.velocity = new Vector2(direccion * Velocidad, RigidBody.velocity.y);
        //Animacion de correr
        animator.SetFloat("velocidad",Mathf.Abs(direccion));

        //Da vuelta el sprite a la izquierda o derecha dependiendo de direccion
        if(direccion > 0)
            transform.localScale = new Vector3(3, 3, 1);
        else if(direccion < 0)
            transform.localScale = new Vector3(-3, 3, 1);
        
        animator.SetBool("salto", estaSaltando);
        
        //Atacar
        if(Input.GetKeyDown(KeyCode.Mouse0))
            Atacar();
        
        animator.SetBool("ataque",estaAtacando);
    }

    //Funcion para saltar
    private void Saltar() {
        //Si es que el jugador ya no puede saltar mas veces
        if(!estaParado && contadorSaltos >= maxSaltos)
            return;
        RigidBody.velocity = Vector2.up * FuerzaDeSalto;
        estaParado = false;
        estaSaltando = true;
        contadorSaltos++;
    }

    private void Atacar() {
        estaAtacando = true;
        animator.SetBool("ataque",estaAtacando);

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
        }

        //Si la normal apunta hacia abajo, el jugador esta tocando techo
        estaTocandoTecho = normal.y <= -0.1f;

        //Si la normal apunta a los lados, el jugador esta tocando una pared
        estaTocandoPared = Mathf.Abs(normal.x) > 0.1f;

        estaAtacando = false;
    }
}
