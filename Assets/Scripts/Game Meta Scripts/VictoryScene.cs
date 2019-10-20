using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class VictoryScene : MonoBehaviour
{

    [SerializeField] TMP_Text time, damage, enemies;
  
    void Start()
    {
        Scores.Stop();
        int Time = (int)Scores.timer;
        time.text = Time.ToString () + "s";
        damage.text = Scores.damageTaken.ToString ();
        enemies.text = Scores.enemiesDefeated.ToString ();


    }
    public void Next(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu(){
        SceneManager.LoadScene("0.0.MainMenu");
        Time.timeScale = 1f;
    }

    public void ForestLevel()
    {
        SceneManager.LoadScene("2.ForestFinal");
    }

    public void SnowWithDesertUnlocked()
    {
        SceneManager.LoadScene("3.SnowFinalDesert");
    }

    public void SnowWithBossUnlocked()
    {
        SceneManager.LoadScene("5.SnowFinalBoss");
    }

    public void DesertLevel()
    {
        SceneManager.LoadScene("4.Desert");
    }

    public void BossLevel()
    {
        SceneManager.LoadScene("6.Factory");
    }


}
