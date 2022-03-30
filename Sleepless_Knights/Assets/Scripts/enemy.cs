using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// represents the enemey class
/// </summary>
public class enemy : MonoBehaviour
{
    public float speed = 3f;
    private Transform target;
    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private float attackSpeed = 1f;
    private float canAttack; 

    /// <summary>
    /// makes the enemy move towards the target player
    /// when trigger effect activates
    /// </summary>
    private void FixedUpdate()
    {
        if(target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }
    /// <summary>
    /// performs attack damage to player health
    /// on collision at a attack speed rate.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(attackSpeed <= canAttack)
            {
                collision.gameObject.GetComponent<PlayerHealth>().updateHealth(-attackDamage);
                canAttack = 0f;
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }
    }

    /// <summary>
    /// When player object enters enemys radius
    /// a trigger effect will take place
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            target = collision.transform;

            Debug.Log(target);
        }
    }

    /// <summary>
    /// when player exits the enemys radius
    /// the trigger effect will stop. 
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            target = null; 
        }
    }
}
