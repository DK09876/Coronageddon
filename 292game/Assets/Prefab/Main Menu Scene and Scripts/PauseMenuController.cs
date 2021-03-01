using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;

    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (isPaused == false){
                Pause();
            }
            else if (isPaused == true){
                Resume();
            }
        }
    }

    void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }
}
