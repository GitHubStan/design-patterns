using System;

namespace StatePattern01.GateStates
{
    public class OpenedGateState : GateState, IGateAction
    {
        private readonly Gate _gate;

        public OpenedGateState(Gate gate)
        {
            _gate = gate;
        }

        public void Enter()
        {
            var message = "You entered an opened gate. Closing gate behind you.";
            Console.WriteLine(message);

            var closedGateState = new ClosedGateState(_gate);
            _gate.ChangeState(closedGateState);
        }

        public void Pay()
        {
            var message = "You do not need to pay at an opened gate!";
            Console.WriteLine(message);
        }
    }
}