using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCamera : MonoBehaviour
{
    private InputManager inputManager;

    [SerializeField] private Vector3 playerOrientation;
    [SerializeField] private Transform cameraOrientation;

    private void Start()
    {
        inputManager = InputManager.Instance;

        HideCursor();
    }

    private void Update()
    {
        Look();
    }

    private void Look()
    {
        Vector3 mouseDelta = inputManager.GetMouseDelta();

        float clampValueX = 180f;
        playerOrientation.x += mouseDelta.x;
        playerOrientation.x = Mathf.Repeat(playerOrientation.x + clampValueX, clampValueX * 2f) - clampValueX;

        float clampValueY = 50f;
        playerOrientation.y -= mouseDelta.y;
        playerOrientation.y = Mathf.Clamp(playerOrientation.y, -clampValueY, clampValueY);

        //vertical
        cameraOrientation.rotation = Quaternion.Euler(new Vector3(playerOrientation.y, cameraOrientation.rotation.eulerAngles.y, 0));

        //horizontal
        transform.rotation = Quaternion.Euler(new Vector3(0, playerOrientation.x, 0));
    }

    private void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
