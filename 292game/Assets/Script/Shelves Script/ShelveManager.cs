using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ShelveManager : MonoBehaviour
{
   public int[,] shelveItems = new int[5,5];
   public float score;
   public Text scoretxt;
   
    // Start is called before the first frame update
    void Start()
    {
        scoretxt.text= "Score:" + score;
        
        //IDs
        shelveItems[1,1] = 1;
        shelveItems[1,2] = 2;
        shelveItems[1,3] = 3;
        shelveItems[1,4] = 4;
    }


    public void BuyOnSelf(){

        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Shelf Item").GetComponent<EventSystem>().currentSelectedGameObject;

        if (score >= shelveItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            score -= shelveItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID];
            scoretxt.text= "Score:" + score;
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
