using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    public GameObject panel;
<<<<<<< HEAD
    private void OnMouseUpAsButton() {
        panel.SetActive(true);
=======
    public static bool gameIsPaused;
    private void OnMouseUpAsButton() {
        panel.SetActive(true);
        gameIsPaused = true;
        PauseGame();
>>>>>>> master
    }
    
    void Update() {
        if (Input.GetMouseButtonDown(1)) {
            panel.SetActive(false);
<<<<<<< HEAD
        }
    }
=======
            gameIsPaused = false;
            ResumeGame();
        }
    }
    
	void PauseGame ()
    {
        Time.timeScale = 0;
    }

	void ResumeGame ()
    {
        Time.timeScale = 1;
    }
>>>>>>> master
}
