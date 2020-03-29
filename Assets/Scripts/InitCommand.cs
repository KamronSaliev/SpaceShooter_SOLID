using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCommand : IRevertableCommand
{
    private readonly GameObject _gameObject;
    
    public InitCommand(GameObject gameObject)
    {
        _gameObject = gameObject;
    }
    
    public void Revert()
    {
        Object.Destroy(_gameObject);
    }
}
