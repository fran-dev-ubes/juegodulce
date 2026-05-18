using UnityEngine;
using UnityEngine.InputSystem;

public class playeramoverse : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxHealth = 5;
    int currentHealth;
    Rigidbody2D rb2D;
    Vector2 moveInput;
    InputSystem_Actions inputActions;
    Animator animator;
    SpriteRenderer spriteRenderer;
    public int Health { get { return currentHealth; } }
    public float invencibleT = 2.0f;
    bool isinvencible;
    float invencibletimer;

    Vector2 lookDirection = new Vector2(1, 0);

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        inputActions = new InputSystem_Actions();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    void Update()
    {

        moveInput = inputActions.Player.Move.ReadValue<Vector2>();

        if (!Mathf.Approximately(moveInput.x, 0.0f) ||
            !Mathf.Approximately(moveInput.y, 0.0f))
        {
            lookDirection.Set(moveInput.x, moveInput.y);
            lookDirection.Normalize();
        }
        if (lookDirection.x > 0)
        {
            spriteRenderer.flipX = false;
            
        }
        else if (lookDirection.x < 0)
        {  spriteRenderer.flipX = true;}

            animator.SetFloat("Left/Right", lookDirection.x);
        animator.SetFloat("Up/Down", lookDirection.y);
        animator.SetFloat("Speed", moveInput.magnitude);

    }

    private void FixedUpdate()
    {
       Vector2 newPosition = rb2D.position + (moveInput * speed * Time.fixedDeltaTime);
        rb2D.MovePosition(newPosition);
    }
   public void ChangeHealth(int amount) { 
    
    currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
    }
        
}

