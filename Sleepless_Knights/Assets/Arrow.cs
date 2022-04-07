using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
      
     public float ArrowDamage;
    //public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        if(gameObject.tag == "Enemy"){
            Debug.Log("Enemy had been attacked");
            enemy enemy = gameObject.GetComponent<enemy>();
            enemy.TakeDamage(ArrowDamage);
        }
        Destroy(gameObject);
    }

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, 1);

    }
}
