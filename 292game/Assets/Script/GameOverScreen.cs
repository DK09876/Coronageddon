using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsGO;
    public void Setup(int score) 
    {
        gameObject.SetActive(true);
        pointsGO.text = score + " points";
    }

    public void PlayAgain()
    {
        //insert name of game screen below
        SceneManager.LoadScene("FINAL");
        ScoreScript.scoreNum = 0;
        Time.timeScale = 1;
    }
}
