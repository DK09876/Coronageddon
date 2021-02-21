using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject spawnObj;

    public float MinX = 0;
    public float MaxX = 10;
    public float MinY = 0;
    public float MaxY = 10;

    void SpawnObject()
    {
    float x = Random.Range(MinX, MaxX);
    float y = Random.Range(MinY, MaxY);
    GameObject spawn = Instantiate(spawnObj, new Vector3(x, y, 0), Quaternion.identity);
    }

}
