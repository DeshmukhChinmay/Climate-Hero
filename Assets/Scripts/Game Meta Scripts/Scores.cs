using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Scores : MonoBehaviour
{
    public static float minutes;
    public static float seconds;
    public static int enemiesDefeated, damageTaken;
    public static int seedCollected;
    static bool stopTimer;
    // Start is called before the first frame update
    void Start()
    {
        minutes = 0f;
        enemiesDefeated = 0;
        damageTaken = 0;
        seedCollected = 0;
        stopTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        //minutes = Timer.endMinutes;
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

   public static void increaseSeedCollect()
    {
        seedCollected++;
    }
}
