using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement playerMovement;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            FindAnyObjectByType<Manager>().EndGame();
        }
    }
}
