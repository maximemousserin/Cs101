namespace Cs101;

public partial class InGameUILogic {
  public static class Output {
    public readonly record struct NumCoinsChanged(
      int NumCoinsCollected, int NumCoinsAtStart
    );
  }
}