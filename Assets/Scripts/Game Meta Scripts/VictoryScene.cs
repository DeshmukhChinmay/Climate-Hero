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
        SceneManager.LoadScene("MainMenu");
    }

    public void ForestLevel()
    {
        SceneManager.LoadScene("Assets/Scenes/DO NOT CHANGE FINAL IMPLEMENTATION UNLESS YOU HAVE PERMISSION/2.ForestFinal.unity");
    }

    public void DesertLevel()
    {
        SceneManager.LoadScene("Assets/Scenes/Test Scenes/Forest_Quest.unity");
    }

    public void BossLevel()
    {
        SceneManager.LoadScene("Assets/Scenes/Test Scenes/Forest_Quest.unity");
    }


}
