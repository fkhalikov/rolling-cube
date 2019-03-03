using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateService 
{
    int GetCurrentLevel();

    void SetLevel(int level);
}
