using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    protected override void Move()
    {
        transform.Rotate(Vector3.forward * movementSpeed * Time.deltaTime);
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
