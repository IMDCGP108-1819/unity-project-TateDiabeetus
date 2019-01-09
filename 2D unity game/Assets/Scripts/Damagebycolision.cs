using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagebycolision : MonoBehaviour
{
    //health for object
   public int health = 1;

    //colision for object, when collision occurs the health is lowered till it hits 0 and destroys the object
    private void OnCollisionEnter2D()
    {
        Debug.Log("collision");

        health--;

        if(health <= 0)
        {
         Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }


}
