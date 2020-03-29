using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : SpaceShip
{
    protected abstract float Speed();
    
    private ICommand _moveCommand;

    private Stack<IRevertableCommand> _executedCommands = new Stack<IRevertableCommand>();

    private void Awake()
    {
        _executedCommands.Push(new InitCommand(gameObject));
        _moveCommand = new MoveCommand(transform, Speed());
    }

    protected override void Move()
    {
        _moveCommand.Execute();
        _executedCommands.Push(_moveCommand);
    }

    private void RevertLastCommand()
    {
        if (_executedCommands.Count == 0) return;
        var lastCommand = _executedCommands.Pop();
        lastCommand.Revert();
    }

    protected override void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            RevertLastCommand();
            return;
        }
        
        base.Update();
    }
}
