using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public int damage= 25;

    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag=="Enemy" ){
            Destroy(this.gameObject);
            col.gameObject.GetComponent<SpreaderHp>().currentHp -= damage;
        }
    }
}
