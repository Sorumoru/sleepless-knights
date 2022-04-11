using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for generating different kinds of objects like
/// Foliage, or other LevelGenerationObjects.
/// </summary>
public class LevelGenerationObjects : MonoBehaviour
{

    public GameObject[] objects;

    /// <summary>
    /// Start is called before the first frame update.
    /// Starts the level generation, instantiates random objects in
    /// the list of GameObject.
    /// </summary>
    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], transform.position, Quaternion.identity);
    }

}
