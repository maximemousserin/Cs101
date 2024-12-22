namespace Cs101;

using Chickensoft.Introspection;
using Chickensoft.LogicBlocks;

public partial class CoinLogic {
  [Meta]
  public abstract partial record State : StateLogic<State>;
}
