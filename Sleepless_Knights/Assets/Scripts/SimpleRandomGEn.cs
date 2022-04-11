using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that generates random objects.
/// </summary>
public class SimpleRandomGEn : MonoBehaviour
{
    public GameObject[] objects;

    /// <summary>
    /// Start is called before the first frame update.
    /// Starts the randomizing.
    /// </summary>
    void Start()
    {
      int rand = Random.Range(0,objects.Length);  
      Instantiate(objects[rand],transform.position,Quaternion.identity);
    }


}
