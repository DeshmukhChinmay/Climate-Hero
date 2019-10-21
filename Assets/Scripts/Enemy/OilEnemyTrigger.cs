using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilEnemyTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag.Equals("Player")) {
            Debug.Log("Player Hit!");
            PlayerHP playerHP = collision.GetComponentInChildren<PlayerHP>();
            
            if (playerHP != null) {
                if (playerHP.GetHealth >0) {
                playerHP.ChangeHealth(-1);
                Debug.Log("Player HP changed");
                }
            } else {
                Debug.Log("The player HP is null!!");
            }
        }
    }

}
