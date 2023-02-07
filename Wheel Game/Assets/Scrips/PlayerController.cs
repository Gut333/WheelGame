using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float verticalForce = 300;
    private float restartDelay = 1f;
    [SerializeField] private ParticleSystem playerParticles;
    [SerializeField] private Color yellowColor;
    [SerializeField] private Color purpleColor;
    [SerializeField] private Color pinkColor;
    [SerializeField] private Color blueColor;
    private string currentColor;

    private Rigidbody2D playerRigidB;
    private SpriteRenderer playerSpriteR;

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
            playerRigidB.velocity = Vector2.zero;
            playerRigidB.AddForce(new Vector2(0f,verticalForce));
        }        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if(!collider.gameObject.CompareTag(currentColor))
        {
            gameObject.SetActive(false);
            Instantiate(playerParticles, transform.position, Quaternion.identity);
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
        if(randomNumber == 0)
        {
            playerSpriteR.color = yellowColor;
            currentColor = "yellow";
        }

        else if(randomNumber == 1)
        {
            playerSpriteR.color = purpleColor;
            currentColor = "purple";
        }

        else if(randomNumber == 2)
        {
            playerSpriteR.color = pinkColor;
            currentColor = "pink";
        }  

        else if(randomNumber == 3)
        {
            playerSpriteR.color = blueColor;
            currentColor = "blue";
        }

    }
}
