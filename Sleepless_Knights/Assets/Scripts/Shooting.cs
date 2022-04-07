using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
       GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        // float ArrowDamages = 10;
        float arrowSlowness = 10;
        // bullet.ArrowDamage = ArrowDamages;

        rb.AddForce(firePoint.up * bulletForce / arrowSlowness, ForceMode2D.Impulse);
        
    }
}
