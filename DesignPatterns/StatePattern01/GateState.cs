namespace StatePattern01
{
    public abstract class GateState
    {
        protected readonly Gate Gate;

        protected GateState(Gate gate)
        {
            Gate = gate;
        }
    }
}
