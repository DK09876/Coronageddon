using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int xpos;
    public int ypos;
    public int enemycount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop(){
        while (enemycount < 2){
            xpos = Random.Range (76,77);
            ypos = Random.Range (46,-62);
            Instantiate(enemy,new Vector3 (xpos,ypos,0), Quaternion.identity);
            yield return new WaitForSeconds(10);
            enemycount += 1;
        }
    }
}
