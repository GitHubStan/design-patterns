using System;

namespace StatePattern01.GateStates
{
    public class OpenedGateState : GateState, IGateAction
    {
        public OpenedGateState(Gate gate) : base(gate)
        {
        }

        public void Enter()
        {
            var message = "You entered an opened gate. Closing gate behind you.";
            Console.WriteLine(message);

            var closedGateState = new ClosedGateState(Gate);
            Gate.ChangeState(closedGateState);
        }

        public void Pay()
        {
            var message = "You do not need to pay at an opened gate!";
            Console.WriteLine(message);
        }
    }
}