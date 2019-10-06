using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Starting Game!");
        SceneManager.LoadScene("Snowy_Area1");
    }

    public void QuitGame()
    {
        Debug.Log("Closing Game!");
        Application.Quit();
    }
}
