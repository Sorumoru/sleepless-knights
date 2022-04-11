using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Another class that represents enemy spawning.
/// </summary>
public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float spawnRadius =2;
    [SerializeField]
    private float timer = 0.1f;
    public GameObject [] enemies;

    /// <summary>
    /// Start is called before the first frame update.
    /// Starts randomizing the enemy.
    /// </summary>
    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    /// <summary>
    /// Randomizes the spawn of the enemy.
    /// </summary>
    /// <returns>a WaitForSeconds object</returns>
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
