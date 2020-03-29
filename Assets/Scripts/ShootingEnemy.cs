using System;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : BaseEnemy
{
    protected override float Speed()
    {
        return 0.01f;
    }
}