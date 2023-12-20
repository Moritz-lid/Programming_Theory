using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    
    protected override void Move()
    {
        transform.Rotate(Vector3.right * movementSpeed * Time.deltaTime);
    }

    private void Start()
    {
        movementSpeed = 40.0f;
    }

    private void Update()
    {
        Move();
    }
}
