using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using Random=UnityEngine.Random;
using Object=UnityEngine.Object;

public class ChangeSpriteBag : MonoBehaviour
{
    Sprite slot;
    private int itemIndex;
    private string itemName;
    public Sprite[] itemsSprites;


    // Start is called before the first frame update
    void Start()
    {
        itemIndex = Random.Range(0, itemsSprites.Length);
        itemName = itemsSprites[itemIndex].name;
        slot = Resources.Load<Sprite>(itemName);
        transform.GetComponent<Image>().sprite = slot;
    }
}
