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

        Vector2 pos = transform.position;

        // restrict player movement to be in the camera always
        //roof and floor of screen
        if(pos.y > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize;
        }
        if (pos.y < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize;
        }
        //sides of screen
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        if (pos.x > widthOrtho)
        {
            pos.x = widthOrtho;
        }
        if (pos.x < -widthOrtho)
        {
            pos.x = -widthOrtho;
        }

        transform.position = pos;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}