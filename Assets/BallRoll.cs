using UnityEngine;

public class BallRoll : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

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

        Vector3 inputXZPlane = new Vector3(movementVector.x, 0, movementVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed * Time.deltaTime);
        Debug.Log("Resultant Vector: " + movementVector);
        Debug.Log("Resultant 3D Vector: " + movementVector);

    }
}
