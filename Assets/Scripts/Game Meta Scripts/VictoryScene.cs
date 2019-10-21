using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class VictoryScene : MonoBehaviour
{

    [SerializeField] TMP_Text time, enemies;
  
    void Start()
    {
        Scores.Stop();
        string minutes = Timer.endMinutes;
        string seconds = Timer.endSeconds;
        time.text = minutes + ":" + seconds;
        enemies.text = Scores.enemiesDefeated.ToString ();


    }
    public void Next(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu(){
        SceneManager.LoadScene("0.0.MainMenu");
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
