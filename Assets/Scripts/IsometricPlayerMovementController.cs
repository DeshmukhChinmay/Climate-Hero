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
        //isoRenderer = GetComponent<IsometricCharacterRenderer>();
        animator = GetComponentInChildren<Animator>();

        lastMove = new Vector2(0f, -0.5f);
        animator.SetFloat("LastMoveX", lastMove.x);
        animator.SetFloat("LastMoveY", lastMove.y);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f 
            || Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
            Vector2 currentPos = rbody.position;
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
            inputVector = Vector2.ClampMagnitude(inputVector, 1);
            Vector2 movement = inputVector * movementSpeed;
            Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
            //isoRenderer.SetDirection(movement);
            rbody.MovePosition(newPos);
            playerMoving = true;
        }
        */
        playerMoving = false;

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (!playerAttacking) { 
            if (horizontal > 0.5f || horizontal < -0.5f)
            {
                transform.Translate(new Vector3(
                    horizontal * movementSpeed * Time.deltaTime, 0f, 0f));
                playerMoving = true;
                lastMove = new Vector2(horizontal, 0f);
            }

            if (vertical > 0.5f || vertical < -0.5f)
            {
                transform.Translate(new Vector3(
                    0f, vertical * movementSpeed * Time.deltaTime, 0f));
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

        if (attackTimeCounter > 0)
        {
            attackTimeCounter -= Time.deltaTime;
        }
        else
        {
            playerAttacking = false;
            animator.SetBool("IsAttacking", false);
        }

        animator.SetFloat("MoveX", horizontal);
        animator.SetFloat("MoveY", vertical);
        animator.SetFloat("LastMoveX", lastMove.x);
        animator.SetFloat("LastMoveY", lastMove.y);
        animator.SetBool("IsMoving", playerMoving);
    }
}
