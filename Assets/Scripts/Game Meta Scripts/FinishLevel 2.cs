using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("UPDATEEE");
        if(GetComponent<EnemyHP>().GetHealth <= 1){
            Debug.Log("DEAD>>>");
            SceneManager.LoadScene("VictoryScene");
        }
    }
}
