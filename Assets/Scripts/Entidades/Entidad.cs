using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entidad : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    public Animator anim;
    public BoxCollider2D bc;


    void Start() {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage) {

        anim.SetTrigger("hurt");
        currentHealth -= damage;

        if(currentHealth <= 0) {
            Die();
        }
    }

    private void Die() {
        anim.SetBool("die",true);
        bc.size = new Vector2(0.1f,0.1f);
        this.enabled = false;
    }
}

