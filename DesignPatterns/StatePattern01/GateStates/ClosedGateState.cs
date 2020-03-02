using System;

namespace StatePattern01.GateStates
{
    public class ClosedGateState : GateState, IGateAction
    {
        public ClosedGateState(Gate gate) : base(gate) 
        {
        }

        public void Enter()
        {
            var message = "You can not enter a closed gate!";
            Console.WriteLine(message);
        }

        public void Pay()
        {
            var message = "Payment received. Opening gate.";
            Console.WriteLine(message);
            
            var openedGateState = new OpenedGateState(Gate);
            Gate.ChangeState(openedGateState);
        }
    }
}
