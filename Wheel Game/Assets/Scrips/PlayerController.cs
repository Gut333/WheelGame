using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float verticalForce = 300;
    private Rigidbody2D playerRigidB;
    private SpriteRenderer playerSpriteR;
    private Color ballColor;

    void Start()
    {
        playerRigidB = GetComponent<Rigidbody2D>();
        ballColor = GetComponent<SpriteRenderer>().color;
        Debug.Log("ball color "+ballColor);
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidB.AddForce(new Vector2(0f,verticalForce));
            playerRigidB.velocity = Vector2.zero;
        }        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        
        Debug.Log(collider.gameObject.tag);
        
        
        

    }
}
