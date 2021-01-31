using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreaderHp : MonoBehaviour
{
   public GameObject player;
   public float HP=100f;
   public float tier1reduc=5f;
   public float tier2reduc=10f;
   public float tier3reduc=20f;
   public float tier4reduc=40f;

   private
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if hit by gameobject(bullet) reduc by player.guntier
        //reduc by guntier and reduce hp and hp bar 


        //if hit by bullet freeze by 2 seconds.
        //checking with "f" key for now
        if (Input.GetKeyDown(KeyCode.F)){
        IEnumerator freezetime= Freezercode();
        StartCoroutine(freezetime);  
        }
    }

    IEnumerator Freezercode(){
        GetComponent<SpreaderMovement>().enabled=false;
        yield return new  WaitForSeconds(2);  //2 second wait
        GetComponent<SpreaderMovement>().enabled=true;
    }
}
