using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private bool touchingGround;

    private void Awake(){
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
    
        //flips the character based on direction
        if (horizontalInput > 0.01f){
            transform.localScale = new Vector3(5, 5, 5);
        }
        else if (horizontalInput < -0.01f){
            transform.localScale = new Vector3(-5, 5, 5);
        }


        if(Input.GetKey(KeyCode.UpArrow) && touchingGround){
            Jump();
        }

        anim.SetBool("running", horizontalInput != 0);
        anim.SetBool("touchingGround", touchingGround);
    }

    private void Jump(){
        body.velocity = new Vector2(body.velocity.x, speed);
        touchingGround = false;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Ground"){
            touchingGround = true;
        }
    }

}

