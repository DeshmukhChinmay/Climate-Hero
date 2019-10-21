using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHP hp = collision.gameObject.GetComponent<PlayerHP>();

        if (hp != null)
        {
            hp.ChangeHealth(-1);
        }

    }
}
