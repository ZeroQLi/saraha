// 1/10/2026 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Vector2 movementInput;

    private void Update()
    {
        // Move the character based on input
        Vector3 movement = new Vector3(movementInput.x, movementInput.y, 0) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    public void OnMove(InputValue value)
    {
        // Get the movement input from the PlayerInput component
        movementInput = value.Get<Vector2>();
    }
}