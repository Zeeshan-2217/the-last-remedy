using UnityEngine;

public class CurePickup : MonoBehaviour
{
    public static bool hasCure = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            hasCure = true;
            gameObject.SetActive(false);
            Debug.Log("Cure collected!");
        }
    }
}