using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricPlayerMovementController : MonoBehaviour
{

    public float movementSpeed = 1f;
    IsometricCharacterRenderer isoRenderer;

    Rigidbody2D rbody;
    Animator animator;

    private bool playerMoving = false;
    private Vector2 lastMove;

    private bool playerAttacking;
    private float attackTimeCounter;
    public float attackTime;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        isoRenderer = GetComponentInChildren<IsometricCharacterRenderer>();
        animator = GetComponentInChildren<Animator>();

        lastMove = new Vector2(0f, -0.5f);
        animator.SetFloat("LastMoveX", lastMove.x);
        animator.SetFloat("LastMoveY", lastMove.y);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        playerMoving = false;

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // movement translation
        if (!playerAttacking) { 
            if (horizontal > 0.5f || horizontal < -0.5f)
            {
                transform.Translate(new Vector3(
                    horizontal, 0f, 0f).normalized * movementSpeed * Time.deltaTime);
                playerMoving = true;
                lastMove = new Vector2(horizontal, 0f);
            }

            if (vertical > 0.5f || vertical < -0.5f)
            {
                transform.Translate(new Vector3(
                    0f, vertical, 0f).normalized * movementSpeed * Time.deltaTime);
                playerMoving = true;
                lastMove = new Vector2(0f, vertical);
            }

            if (Input.GetButtonDown("Fire1"))
            {
                playerAttacking = true;
                attackTimeCounter = attackTime;
                animator.SetBool("IsAttacking", true);

            }
        }

        // add timer between attacks to prevent spam attack
        if (attackTimeCounter > 0)
        {
            attackTimeCounter -= Time.deltaTime;
        }
        else
        {
            playerAttacking = false;
            animator.SetBool("IsAttacking", false);
        }

        // change animator properties
        animator.SetFloat("MoveX", horizontal);
        animator.SetFloat("MoveY", vertical);
        animator.SetFloat("LastMoveX", lastMove.x);
        animator.SetFloat("LastMoveY", lastMove.y);
        animator.SetBool("IsMoving", playerMoving);
    }
}
