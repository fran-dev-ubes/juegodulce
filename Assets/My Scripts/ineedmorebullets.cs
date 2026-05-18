using UnityEngine;

public class ineedmorebullets : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    private void Awake()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
