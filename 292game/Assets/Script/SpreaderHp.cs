using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreaderHp : MonoBehaviour
{
   public SpreaderHpBar spreaderHpBar;
   public Animator animator;
   public Rigidbody2D rb;

   public int maxHp=100;
   public static int currentHp;

   public float tier1reduc=5f;
   public float tier2reduc=10f;
   public float tier3reduc=20f;
   public float tier4reduc=40f;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        spreaderHpBar.SetMaxHp(maxHp);
    }

    // Update is called once per frame
    void Update()
    {
        //if hit by gameobject(bullet) reduc by player.guntier
        //reduc by guntier and reduce hp and hp bar


        //if hit by bullet freeze by 2 seconds.
        //checking with "f" key for now

        //if (Input.GetKeyDown(KeyCode.F)){
        //IEnumerator freezetime= Freezercode();
        //StartCoroutine(freezetime);
        //}
        
        spreaderHpBar.SetHp(currentHp);

        if (currentHp == 0)
        {
          animator.SetBool("die", true);
          rb.constraints = RigidbodyConstraints2D.FreezePosition;
          Destroy(this.gameObject, 1.0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag=="Bullet" ){
            Destroy(col.gameObject);
            SpreaderHp.currentHp -= 25;
        }
    }
}
