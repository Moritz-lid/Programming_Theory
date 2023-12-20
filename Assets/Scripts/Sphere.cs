using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private Vector3 shakeDirectionX;
    private Vector3 shakeDirectionY;
    public Vector3 restPosition;
    public float amplitude;
    public float frequency;

    protected override void Move()
    {
        Vibrate();
    }

    private void Vibrate()
    {
        transform.position = restPosition + shakeDirectionX * Mathf.Sin(frequency * Time.deltaTime) * amplitude + shakeDirectionY * Mathf.Sin(frequency * Time.deltaTime) * amplitude; 
    }
    // Start is called before the first frame update
    void Start()
    {
        shakeDirectionX = new Vector3(1, 0, 0);
        shakeDirectionY = new Vector3(0, 1, 0);
        restPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
