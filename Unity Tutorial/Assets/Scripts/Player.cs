using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player1 : MonoBehaviour
{
    [SerializeField] // visible in inspector panel
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;
    private bool isGrounded;

    private float movementX;
    private Rigidbody2D body;
    private Animator anim;
    private SpriteRenderer sprite;

    private string WALK_ANIMATION = "Walk";
    private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";

    private void Awake() // called at the very beginning
    {
        // gets the reference of components
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    
    void Update() // called once per frame
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        if (Input.GetButtonDown("Jump"))
            Debug.Log("pressed");
        PlayerJump();
    }

    void PlayerMoveKeyboard()
    {
        // gets input when using left/right arrows or A/D
        // -1 for left, 1 for right
        // the Raw version doesn't have any decimals, whereas the non-Raw is a smooth curve with decimals
        movementX = Input.GetAxisRaw("Horizontal");
        // the position is added to a value which is the direction of movement, the move force, and the interval between frames 
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer()
    {
        if (movementX > 0) // right
        {
            anim.SetBool(WALK_ANIMATION, true); // sets the Walk parameter to true, starting walk animation
            sprite.flipX = false; // face right
        }
        else if (movementX < 0) // left
        {
            anim.SetBool(WALK_ANIMATION, true); // sets the Walk parameter to true, starting walk animation
            sprite.flipX = true; // face left
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false); // sets the Walk parameter to false, returning to idle
        }
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded) // if space button held & on ground
        {
            isGrounded = false;
            body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // built in
    {
        if (collision.gameObject.CompareTag(GROUND_TAG)) // if collides with ground
            isGrounded = true;

        if (collision.gameObject.CompareTag(ENEMY_TAG)) // if collides with enemy
            Destroy(gameObject); // destroy self
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(ENEMY_TAG))
            Destroy(gameObject);
        
    }
}
