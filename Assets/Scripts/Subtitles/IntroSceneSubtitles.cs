using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroSceneSubtitles : MonoBehaviour
{
    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Super Ultra Mega Evil Corporation” (SUMEC) is a company which is responsible for the issues for climate change such as deforestation, pollution, etc has had a huge failure had their main production plan.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "They have asked a new intern (the player), to bring them the necessary parts which are required to fix their production plant.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "The intern has to go around different levels; forest, desert, ocean/ice, factory.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        SceneManager.LoadScene("Snowy_Area1");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Snowy_Area1");
    }
}
