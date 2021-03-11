using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameOverScreen gameOverScreen;

    public HealthBar healthBar;
    // public Animator enemyAnimator;

    // Start is called before the first frame update
    void Start()
    {
          currentHealth = maxHealth;
          healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0){
            Destroy(this);
            gameOverScreen.Setup(ScoreScript.scoreNum);
        }
        // else if (enemyAnimator.GetBool("attack") == true)
        // {
        //     Debug.Log("dmg");
        //     TakeDamage(20);
        //     WaitForSecondsRealtime(1);
        // }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy")
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth > 0)
        {
            currentHealth -= damage;

            healthBar.SetHealth(currentHealth);
        }
        else
        {
           Destroy(gameObject);
        }
    }
}
