using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences = new Queue<string>();
    public Text nameText;
    public Text dialogueText;
    //public Animator animator;
    public GameObject dialoguebox;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        dialoguebox.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //animator.SetBool("IsOpen", true);
        Debug.Log("here we are");
        dialoguebox.SetActive(true);

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    public void DisplayNextSentence()
    { 
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
      
        //Debug.Log(sentence.Substring(9));
        nameText.text = sentence.Substring(0,8);
        dialogueText.text = sentence.Substring(9);
    }

    public void EndDialogue()
    {
        //animator.SetBool("IsOpen", false);
        dialoguebox.SetActive(false);
    }
}
