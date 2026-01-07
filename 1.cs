using UnityEngine;

public class TransformGameObj : MonoBehaviour
{
    public float moveSpeed = 5f;  
    public float rotateSpeed = 50f;
    public float scaleSpeed = 0.5f; 

    void Update()
    {
        HandleMovement();
        HandleRotation();
        HandleScaling();
    }

    void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        float moveZ = Input.GetAxis("Vertical");   

        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
        transform.Translate(move);
    }

    void HandleRotation()
    {
        if (Input.GetKey(KeyCode.Q)) // Rotate Left
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E)) // Rotate Right
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    void HandleScaling()
    {
        if (Input.GetKey(KeyCode.R)) // Increase Scale
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.F)) // Decrease Scale
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }
}
