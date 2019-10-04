using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damage = 1;
    public float damageRadius = 1;

    // Update is called once per frame
    void Update()
    {
        // get all colliders in a circle radius
        Collider2D[] colliders = Physics2D.OverlapCircleAll(
            transform.position + transform.right, damageRadius);
        //transform.right
        //Debug.Log(transform.right);

        for (int i = 0; i < colliders.Length; i++)
        {
            // damage all enemies in the player's radius
            if (Input.GetButtonDown("Fire1") && colliders[i].tag == "Enemy")
            {
                colliders[i].GetComponent<EnemyHP>().ChangeHealth(-damage);

                if (colliders[i].GetComponent<EnemyHP>().GetHealth <= 0)
                {
                    Destroy(colliders[i].gameObject);
                }
            }
        }

    }
}
