using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    public int health=10;
    public int maxhealth=10;
    private void Start()
    {
        GameObject enemy = GameObject.Find("Boar (1)");
        EnemyHP enemyScript = enemy.GetComponent<EnemyHP>();
        health = enemyScript.health;
        Debug.Log("================Health is: " + health + "/" + maxhealth);
       // transform.localScale = new Vector3((float)health/maxhealth,1);
    }

        // Update is called once per frame
        void Update()
    {
        GameObject enemy = GameObject.Find("Boar (1)");
        EnemyHP enemyScript = enemy.GetComponent<EnemyHP>();
        health = enemyScript.health;
        Debug.Log("================Health is===============: " + health + "/" + maxhealth);

        transform.localScale = new Vector3((float)health / maxhealth, 1);
    }
}
