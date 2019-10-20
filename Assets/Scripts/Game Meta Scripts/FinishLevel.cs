using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{

    public GameObject boss;

    // Update is called once per frame
    void Update()
    {

        if(GetComponent<EnemyHP>().GetHealth <= 1){
            if (boss.name == "Factory")
            {
                SceneManager.LoadScene("0.2.VictoryScene");
            }
            if (boss.name == "OilPlant")
            {
                SceneManager.LoadScene("0.2.VictoryScene");
            }
        }
    }
}
