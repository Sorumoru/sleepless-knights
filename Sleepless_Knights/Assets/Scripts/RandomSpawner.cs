using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public Transform[] spawnpoints;
    public GameObject[] objects;

    private int enemycount;

    // Start is called before the first frame update
    void Start()
    {
        enemycount = objects.Length;
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateEnemies()
    {

    }
}
