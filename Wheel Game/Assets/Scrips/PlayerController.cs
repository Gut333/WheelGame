using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float verticalForce = 300;
    [SerializeField] private float restartDelay = 1f;
    [SerializeField] private Color greenColor;
    [SerializeField] private Color orangeColor;
    [SerializeField] private Color redColor;
    [SerializeField] private Color blueColor;
    private string currentColor;

    private Rigidbody2D playerRigidB;
    private SpriteRenderer playerSpriteR;
    private Color ballColor;

    void Start()
    {
        playerRigidB = GetComponent<Rigidbody2D>();
        playerSpriteR = GetComponent<SpriteRenderer>();      
        ChangeColor();
        
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
        
        if(!collider.gameObject.CompareTag(currentColor))
        {
            gameObject.SetActive(false);
            Invoke("RestartScene",restartDelay);
        }
              
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void ChangeColor()
    {
        int randomNumber = Random.Range(0, 4);
        Debug.Log(randomNumber);

        if(randomNumber == 0)
        {
            playerSpriteR.color = greenColor;
            currentColor = "green";
        }

        else if(randomNumber == 1)
        {
            playerSpriteR.color = orangeColor;
            currentColor = "orange";
        }

        else if(randomNumber == 2)
        {
            playerSpriteR.color = redColor;
            currentColor = "red";
        }  

        else if(randomNumber == 3)
        {
            playerSpriteR.color = blueColor;
            currentColor = "blue";
        }

    }
}
