using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entidad : MonoBehaviour
{   
    public LayerMask colision; 
    public float currentHealth;
    public float maxHealth;

    //Barra de vida
    public HealthBar vida;
    public Animator anim;
    public BoxCollider2D bc;


    void Awake() {
        currentHealth = maxHealth;
        vida.setMaxHealth(maxHealth);
    }

    public void TakeDamage(float damage) {

        anim.SetTrigger("hurt");
        currentHealth -= damage;

        vida.setHealth(currentHealth);

        if(currentHealth <= 0) {
            Die();
        }
    }

    private void Die() {
        anim.SetBool("die",true);
        bc.size = new Vector2(0.1f,0.1f);
        this.enabled = false;
    }

    public float getCurrentHealth() {
        return currentHealth;
    }
}

