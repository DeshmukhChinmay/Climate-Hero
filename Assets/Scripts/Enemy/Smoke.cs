using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{

    private float speed = 1f;
    public Rigidbody2D rigidBody;
    private Transform player;

    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

        rigidBody = GetComponent<Rigidbody2D>();

        this.player = GameObject.FindWithTag("Player").transform;

        moveDirection = (player.transform.position - transform.position).normalized * speed;
        rigidBody.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 2f);

        // Vector3 playerPos = new Vector3(player.position.x, player.position.y +1, player.position.z);

        // transform.rotation = Quaternion.LookRotation(playerPos);
        // transform.LookAt(player.position);   
    }

    void Update() {
        // transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag.Equals("Player")) {
            Debug.Log("Player Hit!");
            PlayerHP playerHP = collision.GetComponent<PlayerHP>();
            
            if (playerHP != null) {
                if (playerHP.GetHealth >0) {
                playerHP.ChangeHealth(-1);
                Debug.Log("Player HP changed");
                }
            }
            Destroy(gameObject);
        } else if (collision.gameObject.tag.Equals("Obstacle")) {
            Destroy(gameObject);
        }
    }

}
