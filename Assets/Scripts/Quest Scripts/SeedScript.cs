using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedScript : MonoBehaviour
{
    public Text count;
    void Start(){
        ForestQuestScript.completedObjectives = 0;  
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<AudioSource>().Play();
        Destroy(gameObject);
        ForestQuestScript.completeObjective();
        Scores.increaseSeedCollect();
    }
    void Update(){
        count.text = ForestQuestScript.completedObjectives + "/10 seeds collected";
    }
}
