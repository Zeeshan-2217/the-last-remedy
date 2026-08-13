using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject cure; // assign in Inspector
    private bool pressed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !pressed)
        {
            pressed = true;

            // Show the cure
            cure.SetActive(true);

            Debug.Log("Button pressed! Cure dropped.");
        }
    }
}