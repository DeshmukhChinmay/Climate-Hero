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
        
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].tag == "Player") { 

            
                IsLeft = false;
                npc.SetBool("IsPlayerComing", true);
            }
           
            if (Input.GetKeyUp(KeyCode.E) && colliders[i].tag == "Player")
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
}