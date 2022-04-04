using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// player movement based on x and y inputs
/// </summary>
public class PlayerMovement : MonoBehaviour
{

    public Animator animator;

    public float moveSpeed = 5f;

    public Rigidbody2D body;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
