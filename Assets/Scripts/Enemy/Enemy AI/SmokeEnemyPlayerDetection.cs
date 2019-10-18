using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeEnemyPlayerDetection : MonoBehaviour
{

    public GameObject smokeAttack;
    public Transform firePoint;
    

    // Update is called once per frame
    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 2);
        Collider2D player = null;

        for (int i = 0; i < colliders.Length; i++) {
            if (colliders[i].tag == "Player") {
                player = colliders[i];
                Debug.Log("Smoke Enemy found the player!!!");
                break;
            }
        }

        if (player != null) {
            Fire();
        } else {
            Debug.Log("Player not found!");
        }
    }

    void Fire() {
        Instantiate(smokeAttack, firePoint.position, firePoint.rotation);
    }
}
