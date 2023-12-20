using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private float m_movementSpeed;
    public float movementSpeed
    {
        get { return m_movementSpeed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.Log("Value must be positive");
            }
            else
            {
                m_movementSpeed = value;
            }
        }
    }

    protected abstract void Move();
    
}
