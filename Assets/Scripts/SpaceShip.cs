using UnityEngine;

public abstract class SpaceShip : MonoBehaviour
{
    private static readonly int IsDestroyed = Animator.StringToHash("IsDestroyed");
    
    protected virtual void Update()
    {
        Move();
    }

    public void DestroySpaceShip()
    {
        var animator = GetComponent<Animator>();
        animator.SetBool(IsDestroyed, true);
        Destroy(gameObject, 0.5f);

        enabled = false;
    }

    protected abstract void Move();
}