namespace Cs101;

using Chickensoft.AutoInject;
using Chickensoft.GodotNodeInterfaces;
using Godot;
using Chickensoft.Introspection;

public interface ISplash : IControl;

[Meta(typeof(IAutoNode))]
public partial class Splash : Control, ISplash {
  public override void _Notification(int what) => this.Notify(what);

  #region Nodes
  [Node]
  public IAnimationPlayer AnimationPlayer { get; set; } = default!;
  #endregion Nodes

  #region Dependencies
  [Dependency]
  public IAppRepo AppRepo => this.DependOn<IAppRepo>();
  #endregion Dependencies

  public void OnReady() =>
    AnimationPlayer.AnimationFinished += OnAnimationFinished;

  public void OnExitTree()
    => AnimationPlayer.AnimationFinished -= OnAnimationFinished;

  public void OnAnimationFinished(StringName name)
    => AppRepo.SkipSplashScreen();

  public override void _Input(InputEvent @event) {
    // Clicking will skip the splash screen.
    if (@event is InputEventMouseButton mouseButton && mouseButton.Pressed) {
      AppRepo.SkipSplashScreen();
    }
  }
}
