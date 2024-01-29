using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    PlayerInput playerInput;

    private void Start()
    {
        if (Instance != null && Instance != this) Destroy(this);
        Instance = this;

        playerInput = GetComponent<PlayerInput>();
    }

    public Vector2 GetMouseDelta()
    {
        InputAction playerLook = playerInput.actions.FindAction("Look");

        return playerLook.ReadValue<Vector2>();
    }

    public bool PlayerShootThisFrame()
    {
        InputAction playerShoot = playerInput.actions.FindAction("Shoot");

        return playerShoot.triggered;
    }
}
