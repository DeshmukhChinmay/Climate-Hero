﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<Sprite> avatars = new Queue<Sprite>();
    private Queue<string> sentences = new Queue<string>();

    public Image avatarImage;
    public Text nameText;
    public Text dialogueText;
    public GameObject dialoguebox;
    

    // Start is called before the first frame update
    void Start()
    {
        avatars = new Queue<Sprite>();
        sentences = new Queue<string>();
        dialoguebox.SetActive(false);
    }

    // Initiates a set of dialogue text represented by a Dialogue object.
    public void StartDialogue(Dialogue dialogue)
    {
        dialoguebox.SetActive(true);

        avatars.Clear();
        sentences.Clear();

        for(int i = 0; i < dialogue.avatars.Length; i++)
        {
            avatars.Enqueue(dialogue.avatars[i]);
            sentences.Enqueue(dialogue.sentences[i]);
        }

        DisplayNextSentence();
    }

    public void Update()
    {
        // Check for space key input
        if (Input.GetKeyUp(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    
    // Updates the elements of the Dialogue GUI.
    public void DisplayNextSentence()
    { 
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        Sprite avatar = avatars.Dequeue();
        string sentence = sentences.Dequeue();

        avatarImage.sprite = avatar;
        nameText.text = sentence.Substring(0,sentence.IndexOf('\n'));
        dialogueText.text = sentence.Substring(sentence.IndexOf('\n')+1);
    }

    // End the dialogue and disable the dialogue UI box.
    public void EndDialogue()
    {
        //animator.SetBool("IsOpen", false);

        dialoguebox.SetActive(false);
    }
}
