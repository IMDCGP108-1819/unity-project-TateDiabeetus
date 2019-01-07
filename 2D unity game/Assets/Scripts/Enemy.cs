using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject deathEffect;


    private void Update()
    {
        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
        //health is lowered if a projectile hits
        public void TakeDamage(int damage)
        {
            health -= damage;

        }
    
 }
