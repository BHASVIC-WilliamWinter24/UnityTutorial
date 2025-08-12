using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player1 : MonoBehaviour
{
    [SerializeField] // visible in inspector panel
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;
    private Rigidbody2D body;
    private Animator anim;
    private SpriteRenderer sprite;
    private string WALK_ANIMATION = "Walk";


    // Start is called once before Update starts
    private void Awake()
    {
        // gets the reference of components
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
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
}
