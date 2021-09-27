using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject item;
    public float negativeXCoordinates, positiveXCoordinates;
    float randX, nextSpawn;
    Vector2 whereToSpawn;
    public float spawnRate;
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
            randX = Random.Range(negativeXCoordinates, positiveXCoordinates);

            whereToSpawn = new Vector2(randX, transform.position.y);
            GameObject newObject = Instantiate(item, whereToSpawn, Quaternion.identity);
        }
    }
}
