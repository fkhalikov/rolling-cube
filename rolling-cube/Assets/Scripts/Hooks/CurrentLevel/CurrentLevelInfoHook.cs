using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CurrentLevelInfoHook : MonoBehaviour
{
  public Text LevelText;
  
  private IStateService stateService;
  private ILevelManager levelManager;
  [Inject]
  public void Setup(IStateService stateService, ILevelManager levelManager)
  {
    this.stateService = stateService;
    this.levelManager = levelManager;
  }

  public void Start()
  {
    LevelText.text = $"Level {stateService.GetCurrentLevel()} Complete";

    Invoke("GoNextLevel", 2f);
  }

  void GoNextLevel()
  {
    int currentLevel = stateService.GetCurrentLevel();
    stateService.SetLevel(++currentLevel);
    this.levelManager.LoadLevel(currentLevel);
  }

}