using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttact : MonoBehaviour
{
    // Start is called before the first frame update
    public int attactAmount = -1;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHP playerHP = other.GetComponent<PlayerHP>();

        if (playerHP != null)
        {
            if (playerHP.GetHealth >0)
            {
                playerHP.ChangeHealth(attactAmount);
               // Destroy(gameObject); // destroy item used to heal
            }
        }
    }

}
