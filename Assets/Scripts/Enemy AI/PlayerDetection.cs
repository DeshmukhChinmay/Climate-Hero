using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PlayerDetection : MonoBehaviour
{

    Vector2 position;

    public AIDestinationSetter aIDestinationSetter;

    // Start is called before the first frame update
    void Start()
    {
        aIDestinationSetter = GetComponent<AIDestinationSetter>();   
    }

    // Update is called once per frame
    void Update()
    {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position,3);
        Debug.Log(colliders.Length);

        for (int i = 0; i < colliders.Length; i++) {
            Debug.Log(colliders[i].tag);

            if (colliders[i].tag == "Player") {
                Debug.Log("This is getting run");
                aIDestinationSetter.target = colliders[i].GetComponent<Transform>();
            }

        }       

    }



}
