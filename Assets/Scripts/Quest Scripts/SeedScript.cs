using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<AudioSource>().Play();
        Destroy(gameObject);
        ForestQuestScript.completeObjective();
        Scores.increaseSeedCollect();
    }
}
