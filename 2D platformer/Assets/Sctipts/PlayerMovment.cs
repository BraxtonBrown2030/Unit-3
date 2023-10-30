using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using AnimatorController = UnityEditor.Animations.AnimatorController;

public class PlayerMovment : MonoBehaviour
{
    
    [Header("Player movement")]
    [SerializeField] private float speed;
    private Vector3 velocity;
     public float moveSpeed = 5f;
    public float jumpForce = 4f;
    public float gravity = -9.81f;
    [SerializeField] private float jumphight;
    private Rigidbody2D rB2D;
    public SoOpenTrigger sO;
    public Animator anim;
    public float aSpeed;
    public float nospeed;

    [Header("ground check")]
    private bool isgournded;
    public Transform groundcheck;
    [SerializeField] private float groundCheckRadius;
    public LayerMask whatisground;
    private float moveVolocity;

    [Header("Wall Jump")]
    private bool isWall;
    public Transform wallCheck;
    [SerializeField] private float wallCheckRadius;
    public LayerMask whatIsWall;
    [Header("Wall Jump left")]
    private bool isWallL;
    public Transform wallCheckL;
    [SerializeField] private float wallCheckRadiusL;
    public LayerMask whatIsWallL;


    public AudioSource audioSource;
    public AudioClip audioClip;

    void Start()
    {
        isWall = true;
        isgournded = true;
        rB2D = GetComponent<Rigidbody2D>();
         velocity *= .5f;
         anim = GameObject.FindGameObjectWithTag("walker").GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
       
        isgournded = Physics2D.OverlapCircle(groundcheck.position, groundCheckRadius, whatisground);
        isWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        isWallL =  Physics2D.OverlapCircle(wallCheckL.position, wallCheckRadiusL, whatIsWallL);


        moveVolocity = 0f;

        if(isgournded == false)
        {

            rB2D.gravityScale += 1 * Time.deltaTime;

        }
        if(isgournded == true)
        {

            rB2D.gravityScale = 1;

        }
        if(isWallL == true)
        {
            rB2D.gravityScale = 1;
        }

        if(isWall == true)
        {
            rB2D.gravityScale = 1;
        }

        if(Input.GetKey(KeyCode.D))
        {

            moveVolocity = speed;

        }

        if(Input.GetKey(KeyCode.A))
        {

            moveVolocity = -speed;

        }


        rB2D.velocity = new Vector2(moveVolocity, rB2D.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isgournded)
        {

            Jump();

        }

        if(Input.GetKeyDown(KeyCode.Space) && isWall)
        {

            WallJump();

        }

        if(Input.GetKeyDown(KeyCode.Space) && isWallL)
        {

            WallJump();

        }


    }

    public void Jump()
    {

        rB2D.velocity = new Vector2(rB2D.velocity.x, jumphight);
        

    }
    void WallJump()
    {
        
        rB2D.velocity = new Vector2(rB2D.velocity.x, jumphight);

    }
        public void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Coin")
        {
            audioSource.PlayOneShot(audioClip, 1.0f);

        }

    }
}
