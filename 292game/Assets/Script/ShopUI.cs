using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject player;
    public GameObject wall;
    public GameObject Shoppingui;
    public void Resume(){
        Shoppingui.SetActive(false);
        Time.timeScale=1f;
        GameIsPaused=false;
    }

    private void Pause(){
        Shoppingui.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused= true;
    }
    private bool isTouching(){
        return player.GetComponent<Collider2D>().IsTouching(wall.GetComponent<Collider2D>());
    }
    private void Update()
    {
        if (isTouching() && Input.GetMouseButtonDown(0) && (GameIsPaused == false))
        {
            Pause();
        }
    }

    // private void Update()
    // {
    //     if (isTouching())
    //     {
    //         if (Input.GetMouseButtonDown(0))
    //         {
    //             if (GameIsPaused == false)
    //             {
    //                 Pause();
    //             }
    //         }
    //     }
    // }
}