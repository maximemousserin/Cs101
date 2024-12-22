namespace Cs101;

using Chickensoft.Introspection;

public partial class CoinLogic {
  public partial record State {
    [Meta, Id("coin_logic_state_idle")]
    public partial record Idle : State, IGet<Input.StartCollecting> {
      public Transition On(in Input.StartCollecting input) {
        Get<Data>().Target = input.Target.Name;
        return To<Collecting>();
      }
    }
  }
}
