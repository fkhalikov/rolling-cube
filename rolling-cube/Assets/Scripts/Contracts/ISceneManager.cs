using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelManager
{
    void LoadLevel(int level);

    void LoadCompleteLevel();

    void LoadRetryAgain(int level);
}
