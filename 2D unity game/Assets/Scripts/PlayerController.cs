using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        //gets rigidbody2D so the sprite can move
        rb = GetComponent<Rigidbody2D> ();

    }
     void Update()
    {
        //inputs so the player can control the sprite using keys
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}