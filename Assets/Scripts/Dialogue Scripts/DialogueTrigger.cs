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
            transform.position + transform.right, damageRadius);
        bool IsLeft = true;
        npc.SetBool("IsWitchComing", false);

        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].tag == "Witch")
            {
                IsLeft = false;
                npc.SetBool("IsWitchComing", true);
            }
            // damage all enemies in the player's radius
            if (Input.GetKeyUp(KeyCode.Tab) && colliders[i].tag == "Witch")
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }
        }

        if (IsLeft)
        {
            FindObjectOfType<DialogueManager>().EndDialogue();
            npc.SetBool("IsWitchComing", false);
        }

    }
}
