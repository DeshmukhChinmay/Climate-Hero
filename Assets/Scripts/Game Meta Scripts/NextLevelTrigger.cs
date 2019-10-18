using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1);
        bool playerFound = false;

        for (int i = 0; i < colliders.Length; i++) {
            //Debug.Log("There are some colliders detected");
            if (colliders[i].tag == "Player") {
                SceneManager.LoadScene("Forest_Area1");
            }
        }
    }
}
