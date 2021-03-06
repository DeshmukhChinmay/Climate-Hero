﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int maxHealth = 10;
    int currentHealth;
    public int health;
    public int attactAmount = -1;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 10;
        health = currentHealth;
    }

    public int GetHealth
    {
        get
        {
            return currentHealth;
        }
    }

    public void onTriggerEnter2D(Collider2D collision)
    {
            if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHP>().ChangeHealth(-1);
        }
            
        
    }

    // damage or heal a certain amount of health
    public void ChangeHealth(int amount)
    {
        // change health by amount, cannot go below 0 and above maxHealth
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
      
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        health = currentHealth;
        
        Debug.Log("Enemy health is: " + currentHealth + "/" + maxHealth);
    }

    private void Update()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color == Color.red)
        {
            timer += Time.deltaTime;
            if (timer > 0.4f)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                timer = 0;
            }
        }

    }
}
