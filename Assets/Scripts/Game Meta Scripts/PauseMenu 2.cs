using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;
    public GameObject PauseMenuUI;
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(IsPaused){
                Resume();
            } else{
                Pause();
            }
        }
    }
    public void QuitGame(){
        Debug.Log("Closing");
        Application.Quit();
    }

    public void MainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void Resume  (){
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    void Pause(){
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
}
