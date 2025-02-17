using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotationMovement : MonoBehaviour
{
    public float movementSpeed = 4;
    void Update()
    {
        Vector3 movement = new Vector3(0,0,0);
        if (Input.GetKey(KeyCode.W)) 
        {
            movement += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement -= transform.forward * movementSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            movement += transform.right * movementSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            movement -= transform.right * movementSpeed * Time.deltaTime;
        }
        transform.position += movement.normalized * movementSpeed * Time.deltaTime;
    }
}
