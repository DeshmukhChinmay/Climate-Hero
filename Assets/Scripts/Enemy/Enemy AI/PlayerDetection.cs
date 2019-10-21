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

        Collider2D player = null;

        for (int i = 0; i < colliders.Length; i++) {
            
            if (colliders[i].tag == "Player") {
                //Debug.Log("This is getting run");
                player = colliders[i];
                break;
            } 

        }

        if (player != null) {
            aIDestinationSetter.target = player.GetComponent<Transform>();
            Debug.Log("This is getting run");
        } else {
            aIDestinationSetter.target = null;
        }

    }



}
