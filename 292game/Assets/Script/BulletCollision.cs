using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public SpreaderHp spreaderHp;

    public int damage = 25;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name=="Enemy" ){
            Destroy(this.gameObject);
            SpreaderHp.currentHp -= damage;
        }
    }
}
