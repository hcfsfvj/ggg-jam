using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction leftAction;
    public InputAction rightAction;
    public float speed;
    Rigidbody2D rb;
    Vector2 move;

    Vector2 StartPosition;
    

    bool isLeft;

    Animator animator;
    Vector2 moveDirection = new Vector2(1, 0);


    // Start is called once before the first execution of Update after aSe MonoBehaviour is created
    void Start()
    {

        leftAction.Enable();
        rightAction.Enable();
        rb = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!Mathf.Approximately(move.x, 0.0f))
        {

            moveDirection.Normalize();
            animator.SetFloat("Speed", move.magnitude);
        }

        animator.SetFloat("Look x", moveDirection.x);
        animator.SetFloat("Look y", moveDirection.y);

    }

    public void FixedUpdate()
    {

    }



}

