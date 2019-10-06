using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private float damageRadius = 1;
    public Animator npc;

    void Update()
    {
       
        // get all colliders in a circle radius
        Collider2D[] colliders = Physics2D.OverlapCircleAll(
            transform.position, damageRadius);
        bool IsLeft = true;
        npc.SetBool("IsPlayerComing", false);
        Debug.Log("sssss");
        for (int i = 0; i < colliders.Length; i++)
        {
            Debug.Log("sth is here");
            if (colliders[i].tag == "Player")

            {
                Debug.Log("Player is here");
                IsLeft = false;
                npc.SetBool("IsPlayerComing", true);
            }
           
            if (Input.GetKeyUp(KeyCode.Tab) && colliders[i].tag == "Player")
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }
        }

        if (IsLeft)
        {
            FindObjectOfType<DialogueManager>().EndDialogue();
            npc.SetBool("IsPlayerComing", false);
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("collision");
        }
    }
}