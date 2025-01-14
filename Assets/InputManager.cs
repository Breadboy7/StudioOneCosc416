using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    // Update is called once per frame
    void Update()
    {
        Vector2 movementVector = Vector2.zero;
        //Check for user input
        if (Input.GetKey(KeyCode.W))
            movementVector += Vector2.up;
        else if (Input.GetKey(KeyCode.A))
            movementVector += Vector2.left;
        else if (Input.GetKey(KeyCode.S))
            movementVector += Vector2.down;
        else if (Input.GetKey(KeyCode.D))
            movementVector += Vector2.right;

        OnMove?.Invoke(movementVector);
    }
}
