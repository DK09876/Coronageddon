using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreNum = 0;
    Text scoreGUI;

    // Start is called before the first frame update
    void Start()
    {
        scoreGUI = GetComponent<Text>();
    }

    public void Add()
    {
        scoreNum += 2000;   
    }

    public void Subtract()
    {
        if (scoreNum < 500)
        {
            scoreNum = 0;
        }
        else
        {
            scoreNum -= 500;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreGUI.text = scoreNum.ToString();
    }
}
