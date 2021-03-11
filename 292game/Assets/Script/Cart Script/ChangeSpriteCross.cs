using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSpriteCross : MonoBehaviour {
   public GameOverScreen gameOverScreen;
   public static int checkNum;
   public GameObject player;
   Image sourceSprite; //will store sprite renderer
   GameObject g;

   void Start()
   {
      sourceSprite = gameObject.GetComponent<Image>(); //get sprite renderer & store it
   }
 
   public void change(Sprite differentSprite)
   {
      sourceSprite.sprite = differentSprite; //sets sprite renderers sprite
      checkNum += 1;
      if (checkNum >= 5)
      {
         gameOverScreen.Setup(ScoreScript.scoreNum + 2000);
      }
   }
}