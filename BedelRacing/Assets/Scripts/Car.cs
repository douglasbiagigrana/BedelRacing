using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float xMovement = 0;
    public float turnSpeed = 15;

    void Update()
    {
        var zMovement = Input.GetAxis("Vertical");
        var forwardMovement = new Vector3(0, 0, zMovement) * 15 * Time.deltaTime;
        var globalDisplacement = transform.TransformVector(forwardMovement);
        var newPosition = transform.position + globalDisplacement;

        if(Mathf.Abs(newPosition.x) > 15)
        {
            newPosition.x = Mathf.Sign(transform.position.x) * 15;
            newPosition.y = transform.position.y;
            newPosition.z = transform.position.z;
        }

        if(forwardMovement.Equals(Vector3.zero))
        {
            return;
        }

        transform.position = newPosition;

        xMovement = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, xMovement, 0) * turnSpeed * Time.deltaTime);
    }
}
