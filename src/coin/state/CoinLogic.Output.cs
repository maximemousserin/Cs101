namespace Cs101;

using Godot;

public partial class CoinLogic {
  public static class Output {
    public readonly record struct Move(Vector3 GlobalPosition);
    public readonly record struct SelfDestruct();
  }
}
