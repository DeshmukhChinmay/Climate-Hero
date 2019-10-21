using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarPanelScript : MonoBehaviour
{

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<AudioSource>().Play();
        Destroy(gameObject);
        DesertQuestScript.completeObjective();
    }
}
