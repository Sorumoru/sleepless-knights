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
    [SerializeField] Transform hand;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        MovementInput();
        RotateHand();
    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void MovementInput()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
    }

    void RotateHand()
    {
        float angle = Utility.AngleTowardsMouse(hand.position);
        hand.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }
}
