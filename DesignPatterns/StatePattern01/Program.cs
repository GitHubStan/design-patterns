using System;
using Microsoft.VisualBasic;

namespace StatePattern01
{
    class Program
    {
        static void Main()
        {
            var gate = new Gate();

            PerformGateAction(gate.Enter);
            PerformGateAction(gate.Pay);
            PerformGateAction(gate.Pay);
            PerformGateAction(gate.Enter);
            PerformGateAction(gate.Enter);
            PerformGateAction(gate.Pay);
            PerformGateAction(gate.Enter);
            PerformGateAction(gate.PayOk);
            PerformGateAction(gate.PayFailed);
        }
        
        private static void PerformGateAction(Action gateAction)
        {
            Console.BackgroundColor = ConsoleColor.Blue; 
            Console.Write (gateAction.Method.Name);
            Console.ResetColor();
            Console.Write(Strings.Space(1));
            
            gateAction.Invoke();
        }
    }
}
