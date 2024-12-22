namespace Cs101;

using Godot;

public partial class CoinLogic {
  public static class Input {
    public readonly record struct StartCollecting(ICoinCollector Target);
    public readonly record struct PhysicsProcess(
      double Delta, Vector3 GlobalPosition
    );
  }
}
