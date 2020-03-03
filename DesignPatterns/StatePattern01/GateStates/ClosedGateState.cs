using System;
using StatePattern01.GateActions;

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
            var message = "Card received. Processing payment.";
            Console.WriteLine(message);

            var paymentProcessingGateState = new PaymentProcessingGateState(Gate);
            Gate.ChangeState(paymentProcessingGateState);

            var paymentProcessor = new PaymentProcessor();
            paymentProcessor.ProcessPayment(Gate);
        }

        public void PayOk()
        {
            var message = "Payment approved while the gate is gate is close. This should be called from PaymentProcessingGateState. Noop.";
            Console.WriteLine(message);
        }

        public void PayFailed()
        {
            var message = "Payment declined while the gate is gate is close. This should be called from PaymentProcessingGateState. Noop.";
            Console.WriteLine(message);
        }
    }
}
