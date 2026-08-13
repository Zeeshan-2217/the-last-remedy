using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string nextSceneName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (CurePickup.hasCure)
            {
                SceneManager.LoadScene("Win");
            }
            else
            {
                Debug.Log("You need the cure!");
            }
        }
    }
}