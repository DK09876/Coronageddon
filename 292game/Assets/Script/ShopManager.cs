using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{
   public int[,] shopItems= new int[5,5];
   public Text scoretxt;
   public GameObject player;
   public int score;

   
   
    // Start is called before the first frame update
    void Start()
    {
        score = ScoreScript.scoreNum;
        scoretxt.text = score.ToString() + " points to spend";
        //IDs
        shopItems[1,1] = 1;
        shopItems[1,2] = 2;
        shopItems[1,3] = 3;
        shopItems[1,4] = 4;

        //Price
        shopItems[2,1] = 50;
        shopItems[2,2] = 100;
        shopItems[2,3] = 150;
        shopItems[2,4] = 200;
    }
    private void Update() {
            score = ScoreScript.scoreNum;
            scoretxt.text = score.ToString() + " points to spend";
    }

    public void buy(){
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
            if (ButtonRef.GetComponent<ButtonInfo>().ItemID == 5){
                if (score >= 500){
            player.GetComponent<Shooting>().refreshammo();
            ScoreScript.scoreNum-=500;
            }
            return;
        }

        if (score >= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            ScoreScript.scoreNum -= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID];
            player.GetComponent<PlayerTier>().Playertier= shopItems[1,ButtonRef.GetComponent<ButtonInfo>().ItemID];
        }
    }
}
