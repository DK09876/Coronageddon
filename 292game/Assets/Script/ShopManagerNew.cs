using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class ShopManagerNew : MonoBehaviour
{
    public Text scoretxt;
    public int price;

    void Update()
    {
        scoretxt.text = ScoreScript.scoreNum.ToString() + " points to spend";
    }

    public void buyAmmo()
    {
        price = Convert.ToInt32(GameObject.Find("PriceAmmo").GetComponent<Text>().text);
        if (ScoreScript.scoreNum >= price)
        {
            ScoreScript.scoreNum -= price;
            GameObject.Find("Player").GetComponent<Shooting>().refreshammo();
        }
    }

    public void buyTier2()
    {
        price = Convert.ToInt32(GameObject.Find("Price2").GetComponent<Text>().text);
        if (ScoreScript.scoreNum >= price)
        {
            ScoreScript.scoreNum -= price;
            GameObject.Find("Player").GetComponent<PlayerTier>().Playertier= 2;
        }
    }

    public void buyTier3()
    {
        price = Convert.ToInt32(GameObject.Find("Price3").GetComponent<Text>().text);
        if (ScoreScript.scoreNum >= price)
        {
            ScoreScript.scoreNum -= price;
            GameObject.Find("Player").GetComponent<PlayerTier>().Playertier= 3;
        }
    }

    public void buyTier4()
    {
        price = Convert.ToInt32(GameObject.Find("Price4").GetComponent<Text>().text);
        if (ScoreScript.scoreNum >= price)
        {
            ScoreScript.scoreNum -= price;
            GameObject.Find("Player").GetComponent<PlayerTier>().Playertier= 4;
        }
    }
}
