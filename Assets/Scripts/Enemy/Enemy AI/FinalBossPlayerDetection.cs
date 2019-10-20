using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBossPlayerDetection : MonoBehaviour
{

    private float speed = 4f;
    private Rigidbody2D rigidBody;
    private Transform player;

    private float fireWaitTime;

    private float moveWaitTime;

    Vector2 moveDirection;
    public GameObject smokeAttack;
    public Transform firePoint;

    private bool firstShot = true;
    

    // Update is called once per frame
    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 10);
        Collider2D player = null;

        for (int i = 0; i < colliders.Length; i++) {
            if (colliders[i].tag == "Player") {
                player = colliders[i];
                //Debug.Log("Smoke Enemy found the player!!!");
                break;
            }
        }

        if (player != null) {
            Fire();
            Dash();
        } else {
            //Debug.Log("Player not found!");
        }
    }

    void Fire() {

        Instantiate(smokeAttack, firePoint.position, firePoint.rotation);

        // fireWaitTime -= Time.deltaTime;

        // if (firstShot == true) {
        //     Instantiate(smokeAttack, firePoint.position, firePoint.rotation);
        //     firstShot = false;
        // } else if (fireWaitTime <= 0) {

        //     fireWaitTime = 0.5f;

        //     Instantiate(smokeAttack, firePoint.position, firePoint.rotation);
        // }

        // Instantiate(smokeAttack, firePoint.position, firePoint.rotation);
    }

    void Dash() {

        moveWaitTime -= Time.deltaTime;

        if (moveWaitTime <= 0) {
            moveWaitTime = 5f;

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
}
