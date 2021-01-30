using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreaderCough : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float hpreduc1;
    public float hpreduc2;
    public float hpreduc3;
    public float hpreduc4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if within radius of spreader within .... distance of player
        //  if player.masked=false
        //      Gameover.ui
        // else
        //      case: tier 1-4
        //      player.hp-= hpreduc(1-4) //loses 2 hp per second really low so depends on our difficulty
    }
}
