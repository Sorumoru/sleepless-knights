using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that represents an arrow.
/// </summary>
public class Arrow : MonoBehaviour
{
     public float ArrowDamage;

    /// <summary>
    /// Damages an enemy when the arrow hits it.
    /// </summary>
    /// <param name="collision">a Collision2D</param>
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy had been attacked");
            enemy enemy = collision.gameObject.GetComponent<enemy>();
            enemy.TakeDamage(ArrowDamage);
        }
        Destroy(gameObject);
    }

}
