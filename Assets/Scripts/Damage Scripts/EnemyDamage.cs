using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public float damageRadius = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<PlayerHP>().ChangeHealth(-damage);
            if (collision.GetComponent<PlayerHP>().GetHealth <= 0)
            {
                Destroy(collision.gameObject);
            }

        }
    }
}
