using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb2d;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //float newPos = player.position.x + moveHorizontal;
        //player.position.x = newPos;

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }

    void Shoot()
    {

    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    //Check collision name
    //    Debug.Log("collision name = " + col.gameObject.name);
    //    if (col.gameObject.name == "Enemy")
    //    {
    //        Destroy(this);
    //    }
    //}

    void OnCollisionEnter()
    {
        Debug.Log("collision name = " + gameObject.name);
        GameObject.Destroy(gameObject);

    }
}
