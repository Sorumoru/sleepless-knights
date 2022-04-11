using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for spawning different enemies
/// </summary>
public class RandomSpawner : MonoBehaviour
{
    public GameObject[] objects;
    private int enemycount;

    /// <summary>
    /// Start is called before the first frame update.
    /// Generates a random enemy in the spawnpoint.
    /// </summary>
    void Start()
    {
        enemycount = objects.Length;
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }

}
