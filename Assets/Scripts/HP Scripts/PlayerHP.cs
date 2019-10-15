using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxHealth = 10;
    
    int currentHealth;
    public int health;

    public float timeInvincible = 2.0f;
    private bool isInvincible;
    private float invincibleTimer;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 5;
        health = currentHealth;
        
    }

    void FixedUpdate()
    {
        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
            {
                isInvincible = false;
            }
        }
    }

    public int GetHealth
    {
        get {
            return currentHealth;
        }
        
    }

    // damage or heal a certain amount of health
    public void ChangeHealth(int amount)
    {
        // if damaged
        if (amount < 0)
        {
            if (isInvincible)
            {
                return;
            }

            // being timer for invincibility
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        // cannot go below 0 and above maxHealth
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        health = currentHealth;
        //Debug.Log("Health is: " + currentHealth + "/" + maxHealth);
    }
}
