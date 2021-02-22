using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonInfo1 : MonoBehaviour
{

    public int ItemID;
    public Text Pricetxt;
    public GameObject ShelveManager;

    // Update is called once per frame
    void Update()
    {
        Pricetxt.text = "Cost: " + ShelveManager.GetComponent<ShelveManager>().shelveItems[2,ItemID].ToString();
        
    }
}
