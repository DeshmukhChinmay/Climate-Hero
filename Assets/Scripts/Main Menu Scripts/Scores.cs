using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Scores : MonoBehaviour
{
    public static float timer;
    public static int enemiesDefeated, damageTaken;
    static bool stopTimer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        enemiesDefeated = 0;
        damageTaken = 0;
        stopTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopTimer){
            timer += 1 * Time.deltaTime;
            print(timer);
        }
    }

    public static void Stop(){
        stopTimer = true;
    }

    public static void increaseEnemiesDefeated(){
        enemiesDefeated += 1;
    }

    public static void increaseDamageTaken(){
        damageTaken += 1;
    }
}
