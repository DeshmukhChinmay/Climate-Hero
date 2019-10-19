using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatCode : MonoBehaviour
{
    private PlayerHP playerHP;
    public GameObject hearts;
    private bool cheatActive = false;
    private IsometricPlayerMovementController speed;
    private float previousSpeed;

    private void Start()
    {
        playerHP = GetComponentInChildren<PlayerHP>();
        speed = GetComponentInParent<IsometricPlayerMovementController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            if (!cheatActive)
            {
                // activate cheat mode
                cheatActive = true;
                playerHP.enabled = false;
                hearts.SetActive(false);
                previousSpeed = speed.movementSpeed;
                Debug.Log(speed.movementSpeed);
                speed.movementSpeed = 5;
                Debug.Log(speed.movementSpeed);
            }
             else
            {
                // disable cheat mode
                cheatActive = false;
                playerHP.enabled = true;
                hearts.SetActive(true);
                speed.movementSpeed = previousSpeed;
            }
            
        }
    }
}
