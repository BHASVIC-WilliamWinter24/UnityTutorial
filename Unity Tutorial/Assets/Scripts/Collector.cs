using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) // to destroy physical enemies and act as a wall for the player
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Destroy(collision.gameObject); // destroy the game object with which it has collided
    }

    private void OnTriggerEnter2D(Collider2D collision) // to destroy ghosts
    {
        if (collision.CompareTag("Enemy"))
            Destroy(collision.gameObject); 
    }
}
