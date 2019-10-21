using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject Victory;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<EnemyHP>().GetHealth <= 0){
            if (GetComponent<EnemyHP>().tag == "CoalPlant"){
                SceneManager.LoadScene("0.2.ForestVictoryScene");
            }
            if(GetComponent<EnemyHP>().tag == "OilPlant")
            {
                SceneManager.LoadScene("0.2.DesertVictoryScene");
            }
            if (GetComponent<EnemyHP>().tag == "Boss")
            {
                Victory.SetActive(true);
                Destroy(gameObject);
            }
        }
        
    }
}
