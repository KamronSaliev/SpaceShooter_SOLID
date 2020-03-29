using UnityEngine;

public class Player : SpaceShip
{
    [SerializeField] private Observer[] _observers;
    
    public void OnDestroy()
    {
        foreach (var observer in _observers)
        {
            observer.Notify();
        }
    }

    protected override void Move()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * 0.1f, 0f, 0f));
    }
}