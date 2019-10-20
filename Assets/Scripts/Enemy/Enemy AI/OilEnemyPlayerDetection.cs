using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilEnemyPlayerDetection : MonoBehaviour
{

    private float speed = 4f;
    private Rigidbody2D rigidBody;
    private Transform player;

    private float waitTime;

    Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 3);
        Collider2D player = null;

        for (int i = 0; i < colliders.Length; i++) {
            if (colliders[i].tag == "Player") {
                player = colliders[i];
                //Debug.Log("Smoke Enemy found the player!!!");
                break;
            }
        }

        if (player != null) {
            Dash();
        } 

    }

    void Dash() {

        waitTime -= Time.deltaTime;

        if (waitTime <= 0) {
            waitTime = 2f;

            //Debug.Log("Dash is getting called!!!");

            rigidBody = GetComponent<Rigidbody2D>();

            this.player = GameObject.FindWithTag("Player").transform;

            // float movementDistance = speed * Time.deltaTime;
            // transform.position += (player.transform.position - transform.position).normalized * speed * Time.deltaTime;

            moveDirection = (player.transform.position - transform.position).normalized * speed;
            rigidBody.velocity = new Vector2(moveDirection.x, moveDirection.y);

        }

        // Debug.Log("Dash is getting called!!!");

        // rigidBody = GetComponent<Rigidbody2D>();

        // this.player = GameObject.FindWithTag("Player").transform;

        // moveDirection = (player.transform.position - transform.position).normalized * speed;
        // rigidBody.velocity = new Vector2(moveDirection.x, moveDirection.y);
        
    }

    // void Move() {
        
    //     waitTime -= Time.deltaTime;

    //     if (waitTime <= 0) {
    //         waitTime = 0.5f;

    //         rigidBody = GetComponent<Rigidbody2D>();

    //         Vector3 target 

    //         moveDirection = (player.transform.position - transform.position).normalized * speed;
    //         rigidBody.velocity = new Vector2(moveDirection.x, moveDirection.y);
    //     }

    // }
}
