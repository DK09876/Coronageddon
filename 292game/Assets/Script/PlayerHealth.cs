using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
          currentHealth = maxHealth;
          healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //insert attack input here
        if (Input.GetKeyDown(KeyCode.Space) && currentHealth > 0)
        {
          TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
      currentHealth -= damage;

      healthBar.SetHealth(currentHealth);
    }
}
