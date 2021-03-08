using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    public GameObject panel;
    public Transform player;
    public static bool gameIsPaused;
    private void OnMouseUpAsButton() {
        if (Vector3.Distance(this.transform.position,player.position) < 15){ 
        panel.SetActive(true);
        gameIsPaused = true;
        PauseGame();
        }
    }
    
    void Update() {
        if (Input.GetMouseButtonDown(1)) {
            panel.SetActive(false);
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
}
