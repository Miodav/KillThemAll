using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawningEnemy : MonoBehaviour
{
    public GameObject enemy;
    float randX,randY;
    Vector2 WhereToSpawn;
    public float SpawnRate = 2f;
    float nextSpawn = 0.0f;
    private int Cpt = 0;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn && Cpt <= 10)
        {
            nextSpawn = Time.time + SpawnRate;
            randX = Random.Range(-10f, 10f);
            randY = Random.Range(-3.5f, 0.5f);
            WhereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, WhereToSpawn, Quaternion.identity);
            Cpt += 1 ;
        }
 
    }
}
