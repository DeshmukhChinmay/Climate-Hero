using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingScript : MonoBehaviour
{
    public int healAmount = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Healing: " + other);
        PlayerHPController playerHP = other.GetComponent<PlayerHPController>();

        if (playerHP != null)
        {
            print("is trig");
            if (playerHP.GetHealth < playerHP.maxHealth)
            {
                playerHP.ChangeHealth(healAmount);
                Destroy(gameObject); // destroy item used to heal
            }
        }
    }
}
