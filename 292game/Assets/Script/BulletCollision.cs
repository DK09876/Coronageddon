using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public int damage = 15;
    public GameObject player;
    public int tier=1;
    private void Start() {
        player= GameObject.Find("Player");
    }
    private void OnCollisionEnter2D(Collision2D col) {
       
        if (col.gameObject.tag=="Bullet"){
            tier= player.GetComponent<PlayerTier>().Playertier;
            damage = 15  * tier;
            Destroy(col.gameObject);
            this.GetComponent<SpreaderHp>().currentHp -= damage ;
        }
    }
}
