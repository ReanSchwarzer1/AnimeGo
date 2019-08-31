using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerManager : MonoBehaviour
{
    public PlayerMover playerMover;
    public PlayerInput playerInput;

    private void Awake()
    {
        playerMover = GetComponent<PlayerMover>();
        playerInput = GetComponent<PlayerInput>();
        playerInput.inputEnabled = true;
    }
    void Update()
    {
        if(playerMover.isMoving)
        {
            return;
        }
        playerInput.GetKeyInput();

        if(playerInput.v == 0)
        {
            if(playerInput.h < 0)
            {
                playerMover.MoveLeft();
            }
            else if (playerInput.h > 0)
            {
                playerMover.MoveRight();
            }
        }
        else if (playerInput.h == 0)
        {
            if(playerInput.v < 0)
            {
                playerMover.MoveBackward();
            }
            else if (playerInput.v > 0)
            {
                playerMover.MoveForward();
            }
        }
    }
}
