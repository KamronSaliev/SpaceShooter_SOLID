using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<SpaceShip>()?.DestroySpaceShip();
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(new Vector3(0f, 0.1f, 0));
    }
}