using System;

namespace StatePattern01
{
    class Program
    {
        static void Main(string[] args)
        {
            var gate = new Gate();

            PerformGateAction(gate.Enter, "Entering");
            PerformGateAction(gate.Pay, "Paying");
            PerformGateAction(gate.Pay, "Paying");
            PerformGateAction(gate.Enter, "Entering");
            PerformGateAction(gate.Enter, "Entering");
        }

        private static void PerformGateAction(Action gateAction, string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue; 
            Console.Write (message);
            Console.ResetColor();
            Console.Write(" ");
            
            gateAction.Invoke();
        }
    }
}
