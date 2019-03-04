using System;
using UnityEngine;
using Zenject;

public class DefaultInstaller : MonoInstaller<DefaultInstaller>
{
  public void Init()
  {
    Container.Bind<IStateService>().To<StateService>().AsSingle();
    Container.Bind<ILevelManager>().To<GameLevelManager> ().AsSingle();
    Container.Bind<IGameManager>().To<GameManager>().AsSingle();
  }

  public override void InstallBindings()
  {
    Init();
  }
}