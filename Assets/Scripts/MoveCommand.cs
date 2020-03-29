using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand, IRevertableCommand
{
    private readonly Transform _transform;
    private float _speed = 0.01f;
    
    public MoveCommand(Transform transform, float speed)
    {
        _transform = transform;
        _speed = speed;
    }
    
    public void Execute()
    {
        _transform.Translate(new Vector3(0f, _speed, 0));
    }

    public void Revert()
    {
        _transform.Translate(new Vector3(0f, -1 * _speed, 0));
    }
}
