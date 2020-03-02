using StatePattern01.GateStates;

namespace StatePattern01
{
    public class Gate
    {
        private IGateAction _currentState;

        public Gate()
        {
            _currentState = new ClosedGateState(this);
        }

        public void ChangeState(IGateAction gateState)
        {
            _currentState = gateState;
        }

        public void Enter()
        {
            _currentState.Enter();
        }

        public void Pay()
        {
            _currentState.Pay();
        }
    }
}
