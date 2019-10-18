﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHP hp = collision.gameObject.GetComponent<PlayerHP>();

        if (hp != null)
        {
            hp.ChangeHealth(-1);
        }

    }
}
