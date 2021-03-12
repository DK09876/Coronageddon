using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int xpos;
    public int ypos;
    public static int enemycount = 0;

    void Start()
    {
        //enemy = GameObject.Find("Enemy");
        //StartCoroutine(EnemyDrop());
    }
    private void Update() {
        if (enemycount < 2){
            xpos = Random.Range (76,77);
            ypos = Random.Range (46,-62);
            Instantiate(enemy,new Vector3 (xpos,ypos,0), Quaternion.identity);
            enemycount += 1;
        }
    }

    // IEnumerator EnemyDrop(){
    //     Debug.Log(enemycount);
    //     while (enemycount < 2){
    //         xpos = Random.Range (76,77);
    //         ypos = Random.Range (46,-62);
    //         Instantiate(enemy,new Vector3 (xpos,ypos,0), Quaternion.identity);
    //         enemycount += 1;
    //         yield return new WaitForSeconds(5);      
    //     }
    // }
}
