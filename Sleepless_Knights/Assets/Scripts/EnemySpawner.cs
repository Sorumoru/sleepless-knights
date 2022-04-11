using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius =2;
    [SerializeField]
    
    private float timer = 0.1f;

    public GameObject [] enemies;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    IEnumerator SpawnAnEnemy(){
        if (GameObject.Find("player") != null)
        {
            Vector2 spawnPos = GameObject.Find("player").transform.position;
            spawnPos += Random.insideUnitCircle.normalized * spawnRadius;



            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(timer);
            StartCoroutine(SpawnAnEnemy());
        }
    }
}
