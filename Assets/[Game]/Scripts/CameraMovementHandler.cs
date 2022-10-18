using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementHandler : MonoBehaviour
{
    
    [SerializeField] float normalSpeed = 0.7f;
    [SerializeField] float fastSpeed = 2f;
    [SerializeField] float movementSpeed;
    [SerializeField] float movementTime = 5;

    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minZ;
    [SerializeField] float maxZ;

    public Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = fastSpeed;
        }
        else
        {
            movementSpeed = normalSpeed;
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && transform.position.z < 100)
        {
            newPosition += (transform.forward * movementSpeed);
            newPosition.z = Mathf.Clamp(newPosition.z, minZ, maxZ);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            newPosition += (transform.forward * -movementSpeed);
            newPosition.z = Mathf.Clamp(newPosition.z, minZ, maxZ);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition += (transform.right * -movementSpeed);
            newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition += (transform.right * movementSpeed);
            newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        }
        
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);
    }
}
