using System;

public abstract class BaseState
{
    public Enemy enemy; 
    public StateMachine stateMachine;
    public abstract void Enter();
    public abstract void Perform();
    public abstract void Exist();

    internal void Exit()
    {
        throw new NotImplementedException();
    }
}