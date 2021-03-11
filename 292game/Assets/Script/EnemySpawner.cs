using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int xpos;
    public int ypos;
    public static int enemycount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    void Update() {

    }
    IEnumerator EnemyDrop(){
        while (enemycount < 2){
            xpos = Random.Range (76,77);
            ypos = Random.Range (46,-62);
            Instantiate(enemy,new Vector3 (xpos,ypos,0), Quaternion.identity);
            yield return new WaitForSeconds(5);
            enemycount += 1;
        }
    }
}
