using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    // when player walks on top of fire, they get damaged
    void OnTriggerStay2D(Collider2D other)
    {
        PlayerHP playerHP = other.GetComponent<PlayerHP>();
        if (playerHP != null)
        {
            if (playerHP.health > 0)
            {
                playerHP.ChangeHealth(-1);
            }
        }
    }
}
