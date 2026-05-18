using UnityEngine;

public class ebribariuantubimaienemiii : MonoBehaviour
{
    public float speed = 3.0f;
    Rigidbody2D rb2D;
    public bool vertical;
    float timer;
    int direction = 1;
    public float changeTime = 1.5f;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        timer = changeTime;
    }

    // Update is called once per frame
    void Update()
    { 
     timer -= Time.deltaTime;
        if (timer <= 0) { 
         direction = -direction;
            timer = changeTime;
        
        }

        Vector2 position=rb2D.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
            animator.SetFloat("moveX", 0);
            animator.SetFloat("moveY", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
            animator.SetFloat("moveX", direction);
            animator.SetFloat("moveY", 0);
        }
            rb2D.MovePosition(position);
    }
}
