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
        time.text = Scores.timer.ToString ();
        damage.text = Scores.damageTaken.ToString ();
        enemies.text = Scores.enemiesDefeated.ToString ();
    }
    public void Next(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
