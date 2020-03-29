using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : Gun
{
    protected override int NextShot()
    {
        return 2;
    }
}
