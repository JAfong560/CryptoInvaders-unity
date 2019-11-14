using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb2d;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody>();
    }

    //private void Update()
    //{
        
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        float ranNum = Random.Range(-50,50);

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //float newPos = player.position.x + moveHorizontal;
        //player.position.x = newPos;

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(ranNum, ranNum);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collision name = " + gameObject.name);
        if(col.gameObject.name == "Player")
        GameObject.Destroy(gameObject);

    }

    void Shoot()
    {

    }
}
