using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage : MonoBehaviour
{
    public int damage = 1;
    public float damageRadius = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GetComponent<AudioSource>().Play();
            collision.GetComponent<EnemyHP>().ChangeHealth(-damage);
            if (collision.GetComponent<EnemyHP>().GetHealth <= 0)
            {
                Destroy(collision.transform.parent.transform.parent.gameObject);
                Destroy(collision.gameObject);
                Scores.increaseEnemiesDefeated();
            }

        }
    }
}
