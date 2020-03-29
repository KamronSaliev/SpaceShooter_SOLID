using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeEnemy : BaseEnemy
{
    protected override float Speed()
    {
        return 0.1f;
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<SpaceShip>()?.DestroySpaceShip();
        Destroy(gameObject);
    }
}
