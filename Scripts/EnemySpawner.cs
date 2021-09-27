using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public GameObject enemy;
    float randX, nextSpawn, randSize;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    public int spawnCount;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-4f, 4f);
            randSize = Random.Range(0.2f, 1.5f);
            
            whereToSpawn = new Vector2(randX, transform.position.y);
            GameObject newObject = Instantiate(enemy, whereToSpawn, Quaternion.identity);
            newObject.transform.localScale = new Vector3(randSize, randSize, 0f);
        }
    }
}
