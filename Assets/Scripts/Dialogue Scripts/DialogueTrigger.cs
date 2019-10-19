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
<<<<<<< HEAD
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
=======
       
        // get all colliders in a circle radius
        Collider2D[] colliders = Physics2D.OverlapCircleAll(
            transform.position, damageRadius);
        bool IsLeft = true;
        //npc.SetBool("IsPlayerComing", false);
        
        for (int i = 0; i < colliders.Length; i++)
        {
            Debug.Log("im here");
            if (colliders[i].tag == "Player") {
                Debug.Log("im here");
                IsLeft = false;
                //npc.SetBool("IsPlayerComing", true);
                
            }
           
           
            if (Input.GetKeyUp(KeyCode.E) && colliders[i].tag == "Player")
            {
                Debug.Log("im here");
>>>>>>> 0a9a1e284395a3435e149ac985489db12a9e0c25

            npc.SetBool("IsPlayerComing", true);
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