using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateService : IStateService
{
  private static int currentLevel = 1;

  public StateService()
  {
    Debug.Log("New state service created");
  }

  public int GetCurrentLevel()
  {
    return currentLevel;
  }

  public void SetLevel(int level)
  {
    Debug.Log("Level set to "+level);
    currentLevel = level;
  }

}
