using UnityEngine;
using UnityEngine.InputSystem;

public class Player_movement : MonoBehaviour
{
    public float speed = 5f;

    public float minX = -2.15f;
    public float maxX = 2.15f;
    public float minY = -2.15f;
    public float maxY = 2.15f;

    void Update()
    {
        if (Keyboard.current == null)
            return;

        Vector2 direction = Vector2.zero;

        if (Keyboard.current.leftArrowKey.isPressed ||
            Keyboard.current.aKey.isPressed)
        {
            direction.x -= 5;
        }

        if (Keyboard.current.rightArrowKey.isPressed ||
            Keyboard.current.dKey.isPressed)
        {
            direction.x += 5;
        }

        if (Keyboard.current.upArrowKey.isPressed ||
            Keyboard.current.wKey.isPressed)
        {
            direction.y += 5;
        }

        if (Keyboard.current.downArrowKey.isPressed ||
            Keyboard.current.sKey.isPressed)
        {
            direction.y -= 5;
        }

        if (direction.magnitude > 5)
            direction = Vector2.ClampMagnitude(direction, 5f);

        Vector3 nextPosition =
            transform.position + (Vector3)(direction * speed * Time.deltaTime);

        nextPosition.x = Mathf.Clamp(nextPosition.x, minX, maxX);
        nextPosition.y = Mathf.Clamp(nextPosition.y, minY, maxY);

        transform.position = nextPosition;
    }
}