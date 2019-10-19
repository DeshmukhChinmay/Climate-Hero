using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
  
    private float damageRadius = 1;
    //public Animator npc;

    private bool playerInRange;

    private void Start()
    {
        playerInRange = false;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && playerInRange)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered the range of an NPC!");
            playerInRange = true;

            //npc.SetBool("IsPlayerComing", true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has exited the range of an NPC.");
            playerInRange = false;

            // Exits dialogue if the player leaves the range of the NPC
            FindObjectOfType<DialogueManager>().EndDialogue();
            //npc.SetBool("IsPlayerComing", false);
        }
    }
}