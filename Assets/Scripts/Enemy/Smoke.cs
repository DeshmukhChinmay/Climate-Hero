using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{

    private float speed = 10f;
    // public RigidBody2D rigidBody; 

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {

        this.player = GameObject.FindWithTag("Player").transform;

        Vector3 playerPos = new Vector3(player.position.x, player.position.y +1, player.position.z);

        transform.rotation = Quaternion.LookRotation(playerPos);
        transform.LookAt(player.position);   
    }

    void Update() {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

}
