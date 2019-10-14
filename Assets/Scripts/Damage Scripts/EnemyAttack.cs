﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public int attackAmount = -1;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHP playerHP = other.GetComponent<PlayerHP>();

        if (playerHP != null)
        {
            if (playerHP.GetHealth >0)
            {
                playerHP.ChangeHealth(attackAmount);
               // Destroy(gameObject); // destroy item used to heal
            }
        }
    }

}
