using UnityEngine;
using Zenject;

public class EndTrigger : MonoBehaviour
{

  public GameManager gameManager;

  // Use this for initialization
  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
      gameManager.CompleteLevel();
  }
}
