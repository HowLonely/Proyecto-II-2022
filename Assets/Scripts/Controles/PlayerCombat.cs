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

    private void Awake() {

        controls = new PlayerControls();
        controls.Enable();

        controls.Gameplay.Atacar.performed += ctx => {
            if(Time.time >= E_Basico) {
                AtaqueBasico();
                E_Basico = Time.time + 1f / V_Basico;
            }
        };
    }

    void AtaqueBasico() {
        //animacion
        anim.SetTrigger("ataque1");

        Collider2D [] enemigosGolpeados = Physics2D.OverlapCircleAll(H_ataqueBasico.position, R_Basico, enemyLayers);

        foreach(Collider2D enemy in enemigosGolpeados){ 
            enemy.GetComponent<Entidad>().TakeDamage(D_Basico);
            animVFX.SetTrigger("golpe");
        }
    }

    void OnDrawGizmosSelected() {
        if(H_ataqueBasico == null) {
            return;
        }
        Gizmos.DrawWireSphere(H_ataqueBasico.position, R_Basico);
    }
}
