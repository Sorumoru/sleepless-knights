using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that implements the player shooting an arrow using
/// the bow.
/// </summary>
public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    /// <summary>
    /// Update is called once per frame.
    /// Checks if the player presses the mouse1 button,
    /// then calls the Shoot() method.
    /// </summary>
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    /// <summary>
    /// Creates a bullet prefab that shoots at a certain direction.
    /// </summary>
    void Shoot()
    {
       GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        float arrowSlowness = 10;

        rb.AddForce(firePoint.up * bulletForce / arrowSlowness, ForceMode2D.Impulse);
        
    }
}
