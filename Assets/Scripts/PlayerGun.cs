using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : Gun
{
    protected override int NextShot()
    {
        return 3;
    }
    
    protected override bool CanShoot()
    {
        return Input.GetKeyDown(KeyCode.Space) && base.CanShoot();
    }
}
