using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public Text Pricetxt;
    public GameObject ShopManager;

    // Update is called once per frame
    void Update()
    {
        Pricetxt.text = "Cost: " + ShopManager.GetComponent<ShopManager>().shopItems[2,ItemID].ToString();
        
    }
}
