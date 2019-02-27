using UnityEngine;
using System.Collections;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            gameManager.CompleteLevel();
    }
}
