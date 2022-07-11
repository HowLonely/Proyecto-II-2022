using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCombat : MonoBehaviour
{
    public PlayerControls controls;
    public Animator anim;
    public Animator animVFX;

    //H_ significa hitbox
    //R_ rango
    //D_ daño
    //V_ velocidad de ataque
    //E_ tiempo entre ataques(enfriamiento)
    public Transform H_ataqueBasico;
    public float R_Basico = 0.5f;
    public float D_Basico = 50;
    public float V_Basico = 5f;
    public float E_Basico = 0;
    public LayerMask enemyLayers;


    public Transform H_Fuerte;
    public float R_Fuerte = 0.8f;
    public float D_Fuerte = 200;
    public float V_Fuerte = 10f;
    public float E_Fuerte = 0;

    private void Awake() {

        controls = new PlayerControls();
        controls.Enable();

        controls.Gameplay.Atacar.performed += ctx => {
            if(Time.time >= E_Basico) {
                AtaqueBasico();
                E_Basico = Time.time + 1f / V_Basico;
            }
        };
        controls.Gameplay.AtacarFuerte.performed += ctx => {
            if(Time.time >= E_Fuerte) {
                AtaqueFuerte();
                E_Fuerte = Time.time + 1f / V_Fuerte;
            }
        };
    }

    void AtaqueBasico() {
        //animacion
        if(anim.GetBool("agachado") == true) {
            anim.SetTrigger("ataque1agachado");
        } else if(anim.GetBool("salto")){
            anim.SetTrigger("ataque1saltando");
        }
        else {
            anim.SetTrigger("ataque1");
        }

        Collider2D [] enemigosGolpeados = Physics2D.OverlapCircleAll(H_ataqueBasico.position, R_Basico, enemyLayers);

        foreach(Collider2D enemy in enemigosGolpeados){ 
            enemy.GetComponent<Entidad>().TakeDamage(D_Basico);
            animVFX.SetTrigger("golpe");
        }
    }

    void AtaqueFuerte() {
         if(anim.GetBool("agachado") == true) {
            anim.SetTrigger("ataque2agachado");
        } else if(anim.GetBool("salto")){
            anim.SetTrigger("ataque2saltando");
        }
        else {
            anim.SetTrigger("ataque2");
        }

        Collider2D [] enemigosGolpeados = Physics2D.OverlapCircleAll(H_Fuerte.position, R_Fuerte, enemyLayers);

        foreach(Collider2D enemy in enemigosGolpeados){ 
            enemy.GetComponent<Entidad>().TakeDamage(D_Fuerte);
            animVFX.SetTrigger("golpe");
        }

    }


    void OnDrawGizmosSelected() {
        if(H_ataqueBasico == null) {
            return;
        }
        Gizmos.DrawWireSphere(H_ataqueBasico.position, R_Basico);

        if(H_Fuerte == null) {
            return;
        }
        Gizmos.DrawWireSphere(H_Fuerte.position, R_Fuerte);
    }
}
