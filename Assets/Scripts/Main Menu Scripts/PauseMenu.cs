using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
 
    public void QuitGame(){
        Debug.Log("Closing");
        Application.Quit();
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    
    public void Resume(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
