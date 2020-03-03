using StatePattern01.GateActions;
using StatePattern01.GateStates;

namespace StatePattern01
{
    public class Gate : IGateAction
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

        public void PayOk()
        {
            _currentState.PayOk();
        }

        public void PayFailed()
        {
            _currentState.PayFailed();
        }
    }
}
