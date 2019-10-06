using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    public int attactAmount = -1;

    void GetHurt(Collider2D other)
    {
        PlayerHP playerHP = other.GetComponent<PlayerHP>();

        if (playerHP != null)
        {
            
         playerHP.ChangeHealth(attactAmount);
                
        }
    }


    // Update is called once per frame
    void Update()
    {
        
        
    }
}
