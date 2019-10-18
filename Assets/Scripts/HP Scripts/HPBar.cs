using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    public int health=10;
    public int maxhealth=10;
    private void Start()
    {
        var parent = this.transform.parent;
        var p1 = parent.transform.parent;
        var enemy = p1.transform.parent;
        EnemyHP enemyScript = enemy.GetComponent<EnemyHP>();
        health = enemyScript.health;
        //Debug.Log("================Health is: " + health + "/" + maxhealth);
       // transform.localScale = new Vector3((float)health/maxhealth,1);
    }

        // Update is called once per frame
        void Update()
    {
        var parent = this.transform.parent;
        var p1 = parent.transform.parent;
        var enemy = p1.transform.parent;
        EnemyHP enemyScript = enemy.GetComponent<EnemyHP>();
        health = enemyScript.health;
        //Debug.Log("================Health is===============: " + health + "/" + maxhealth);

        transform.localScale = new Vector3((float)health / maxhealth, 1);
    }
}
