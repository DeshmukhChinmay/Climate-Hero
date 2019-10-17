using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSpawner : MonoBehaviour
{

    public GameObject foodObject;

    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("This is getting run!!!!!!!!!!");

        var values = new List<int>();

        for (int i = 1; i <= spawnPoints.Length; i++) {
            values.Add(i);
            Debug.Log(spawnPoints.Length);
        }

        for (int j = 0; j < (spawnPoints.Length/2); j++) {
            bool validNumber = false;
            while(!validNumber) {
                var number = Random.Range(0, spawnPoints.Length-1);
                if (values.Contains(number)) {
                    Instantiate(foodObject, spawnPoints[number].position, spawnPoints[number].rotation);
                    values.Remove(number); 
                    validNumber = true;
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
