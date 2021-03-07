 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class ChangeSpriteCross : MonoBehaviour {
 
     Image sourceSprite; //will store sprite renderer
     GameObject g;
 
     void Start()
     {
        sourceSprite = gameObject.GetComponent<Image>(); //get sprite renderer & store it
     }
 
     public void change(Sprite differentSprite)
     {
        sourceSprite.sprite = differentSprite; //sets sprite renderers sprite
     }
 }