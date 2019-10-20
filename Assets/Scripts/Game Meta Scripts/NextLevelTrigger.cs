using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour
{
    public GameObject trigger;

    // Update is called once per frame
    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1);

        for (int i = 0; i < colliders.Length; i++) {
            //Debug.Log("There are some colliders detected");
            if (colliders[i].tag == "Player") {
                if (trigger.name == "ForestLevelTrigger"){
                    SceneManager.LoadScene("2.ForestFinal");
                }
                if (trigger.name == "DesertLevelTrigger"){
                    SceneManager.LoadScene("4.Desert");
                }
                if (trigger.name == "FinalLevelTrigger"){
                    SceneManager.LoadScene("6.Factory");
                }
            }
        }
    }
}
