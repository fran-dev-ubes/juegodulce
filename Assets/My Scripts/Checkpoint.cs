using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool checkpointActive = false;

    public Sprite spriteActive;
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !checkpointActive)
        {
            checkpointActive = true;
        }
    }

    
}
