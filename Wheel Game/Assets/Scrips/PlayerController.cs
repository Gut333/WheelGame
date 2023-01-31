using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float verticalForce = 300;
    private Rigidbody2D playerRigidB;

    void Start()
    {
        playerRigidB = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidB.AddForce(new Vector2(0f,verticalForce));
            playerRigidB.velocity = Vector2.zero;
        }        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("colisionando con " + collision);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("colisionando con " + collider);

    }
}
