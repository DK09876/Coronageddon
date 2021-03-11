using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreaderHp : MonoBehaviour
{
    public SpreaderHpBar spreaderHpBar;
    public Animator animator;
    public Rigidbody2D rb;

    public int xpos;
    public int ypos;


    public int maxHp=100;
    public int currentHp;
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
        spreaderHpBar.SetHp(currentHp);

        if (currentHp <= 0)
        {
            ScoreScript.scoreNum += 10;
            animator.SetBool("die", true);
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            Destroy(this.gameObject, 1.0f);
        }
    }
}
