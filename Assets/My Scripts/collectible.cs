using UnityEngine;

public class collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playeramoverse controller = collision.GetComponent<playeramoverse>();
        if (controller != null)
        {
            controller.ChangeHealth(1);
            Debug.Log("you gain health by one point");
            Destroy(gameObject);
        }
    }
}
