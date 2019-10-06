using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int maxHealth = 10;
    int currentHealth;
    public int health;

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

    // damage or heal a certain amount of health
    public void ChangeHealth(int amount)
    {
        // change health by amount, cannot go below 0 and above maxHealth
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        health = currentHealth;
        Debug.Log("Enemy health is: " + currentHealth + "/" + maxHealth);
    }
}
