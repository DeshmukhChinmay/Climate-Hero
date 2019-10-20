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
            if (GetComponent<EnemyHP>().tag == "CoalPlant"){
                SceneManager.LoadScene("0.2.ForestVictoryScene");
            }
            if(GetComponent<EnemyHP>().tag == "OilFactory")
            {
                SceneManager.LoadScene("0.2.DesertVictoryScene");
            }
        }
        
    }
}
