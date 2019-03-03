using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class GameManager : MonoBehaviour, IGameManager
{

  bool gameHasEnded = false;
  private ILevelManager levelManager = null;
  private IStateService stateService = null;

  public Text messageText;
  public float restartDelay = 1f;

  [Inject]
  public void Setup(ILevelManager sceneManager
      , IStateService stateService)
  {
    this.levelManager = sceneManager;
    this.stateService = stateService;
  }

  public void CompleteLevel()
  {
    int currentLevel = stateService.GetCurrentLevel();

    this.levelManager.LoadCompleteLevel();

  }

  public void EndGame()
  {
    if (gameHasEnded == false)
    {
      gameHasEnded = true;
      messageText.text = "LET'S TRY AGAIN";
      Invoke("Restart", restartDelay);
    }
  }

  void Restart()
  {
    levelManager.LoadLevel(stateService.GetCurrentLevel());
  }
}
