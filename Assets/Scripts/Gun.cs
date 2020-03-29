using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    protected Transform _spawnPoint;
    
    public GameObject BulletPrefab;
    
    protected float _lastShot;
    
    protected abstract int NextShot();
    
    private void Start()
    {
        _spawnPoint = transform.GetChild(0);
        
        _lastShot = Time.time;
    }
    
    private void Shoot()
    {
        _lastShot = Time.time;
        Instantiate(BulletPrefab, _spawnPoint.position, transform.rotation);
    }
    
    protected void Update()
    {
        if (CanShoot())
            Shoot();
    }    

    protected virtual bool CanShoot()
    {
        return _lastShot + NextShot() < Time.time;
    }
}
