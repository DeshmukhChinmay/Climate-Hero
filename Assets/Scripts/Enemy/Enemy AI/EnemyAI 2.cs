using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{

    public float speed = 1000f;
    public float nextWayPointDistance = 2;
    
    Transform target = null;

    Path path;
    int currentWaypoint = 0;
     bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rigidBody = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0, 0.5f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (detectPlayer() == true) {
            CalculatePath();
        } else {
            return;
        } 

    }

    void OnPathComplete(Path p)
    {
        if (!p.error) {
            path = p;
            currentWaypoint = 0;
        }

    }

    void UpdatePath() {
        
        if (seeker.IsDone() && target != null) {
            seeker.StartPath(rigidBody.position, target.position, OnPathComplete);
        }

    }

    bool detectPlayer() {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 2);
        bool playerFound = false;

        for (int i = 0; i < colliders.Length; i++) {
            Debug.Log("There are some colliders detected");
            if (colliders[i].tag == "Player") {
                target = colliders[i].GetComponent<Transform>();
                return true;
            }
        }

        return playerFound;

    }

    void CalculatePath() {
        
        if (path == null) {
            return;
        }   

        if (currentWaypoint >= path.vectorPath.Count) {
            reachedEndOfPath = true;
            return;
        } else {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2) path.vectorPath[currentWaypoint] - rigidBody.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rigidBody.AddForce(force);

        float distance = Vector2.Distance(rigidBody.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWayPointDistance) {
            currentWaypoint++;
        }

    }

}
