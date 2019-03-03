public interface IGameManager
{
  void CompleteLevel();
  void EndGame();
  void Setup(ILevelManager sceneManager, IStateService stateService);
}