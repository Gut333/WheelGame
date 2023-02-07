using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] float wheelVelocity = 0.5f;
    Rigidbody2D wheelRigidB;
    Color wheelColor;

    void Awake()
    {
        wheelRigidB = GetComponent<Rigidbody2D>();
        wheelColor = GetComponentInChildren<SpriteRenderer>().color;
        Debug.Log("wheel color " + wheelColor);
        
    }



    void Update()
    {
        wheelRigidB.transform.Rotate(new Vector3(0f,0f,wheelVelocity));
    }
}
