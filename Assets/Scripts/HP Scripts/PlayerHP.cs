using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int maxHealth = 10;
    
    int currentHealth;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 5;
        health = currentHealth;
        
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
        // change health by amount, cannot go below 0 and above maxHealth
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        health = currentHealth;
        Debug.Log("Health is: " + currentHealth + "/" + maxHealth);
    }
}
