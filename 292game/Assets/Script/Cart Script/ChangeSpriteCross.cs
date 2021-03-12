using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSpriteCross : MonoBehaviour {
   public GameOverScreen gameOverScreen;
   public static int checkNum;
   Image sourceSprite; //will store sprite renderer

   void Start()
   {
      sourceSprite = gameObject.GetComponent<Image>(); //get sprite renderer & store it
   }
 
   public void change(Sprite differentSprite)
   {
      if (checkNum >= 4)
      {
         checkNum = 0;
         gameOverScreen.Setup(ScoreScript.scoreNum + 2000);
      }
      else
      {
         checkNum++;
         sourceSprite.sprite = differentSprite; //sets sprite renderers sprite
      }
   }
   public void BtnOnClick() 
   {
      gameObject.GetComponent<Button>().interactable = false; 
   }
}

