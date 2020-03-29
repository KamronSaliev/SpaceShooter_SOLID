using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRevertableCommand
{
    void Revert();
}
