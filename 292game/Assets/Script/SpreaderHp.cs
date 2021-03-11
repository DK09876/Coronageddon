using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreaderHp : MonoBehaviour
{
    public SpreaderHpBar spreaderHpBar;
    public Animator animator;
    public Rigidbody2D rb;

    public GameObject player;

    public int maxHp=100;
    public int currentHp;
  

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

        if (currentHp <= 0)
        {
            ScoreScript.scoreNum += 100;
            EnemySpawner.enemycount-= 1;
            animator.SetBool("die", true);
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            this.gameObject.SetActive(false);
            Debug.Log(EnemySpawner.enemycount);
        }
    }
}
