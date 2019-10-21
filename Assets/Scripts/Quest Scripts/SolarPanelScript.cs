using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarPanelScript : MonoBehaviour
{

    public Text count;
    void Start(){
        DesertQuestScript.completedObjectives = 0;    
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<AudioSource>().Play();
        Destroy(gameObject);
        DesertQuestScript.completeObjective();
    }
// Update is called once per frame
    void Update(){
        count.text = DesertQuestScript.completedObjectives + "/8 solar panels collected";
    }
}
