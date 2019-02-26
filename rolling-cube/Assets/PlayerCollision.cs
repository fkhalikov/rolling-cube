using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement playerMovement;

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
            playerMovement.enabled = false;
    }
}
