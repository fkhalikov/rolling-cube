using UnityEngine;
using Zenject;

public class DefaultInstaller : MonoInstaller<DefaultInstaller>
{
  public override void InstallBindings()
  {
    Container.Bind<IStateService>().To<StateService>().AsSingle();
    Container.Bind<ILevelManager>().To<GameLevelManager> ().AsSingle();
    Container.Bind<IGameManager>().To<GameManager>().AsSingle();
  }
}