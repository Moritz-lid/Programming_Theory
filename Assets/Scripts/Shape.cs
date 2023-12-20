using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public float movementSpeed;

    protected abstract void Move();
    
}
