using UnityEngine;

public class mepicanlococo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playeramoverse controller= collision.GetComponent<playeramoverse>();
        if (controller != null )
        {
            controller.ChangeHealth(-1);
            Debug.Log("you lose health one point");
        }
    }
}
