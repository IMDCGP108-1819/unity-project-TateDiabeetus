using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectille : MonoBehaviour
{

    public float speed;
    public float lifeTime;
    public float distance;
    public LayerMask whatIsSolid;

    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        //colision when hitting something tagged: "enemy"
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null) {
            if (hitInfo.collider.CompareTag("enemy")) {
                Debug.Log("Enemy Must Take Damage");
            }
            DestroyProjectile();
        }
    
    
        //code to make the projectile move when spawned
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        //code for another prefab to spawn on projectile death
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

