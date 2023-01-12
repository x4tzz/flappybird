using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
 
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public Logicofgame logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicofgame>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > 17 )
        {
            logic.gameOver();
        }
        if (transform.position.y < -17)
        {
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

}