using UnityEngine;

public class Bullet : Entity
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float destroyDelay = 2f;

    private Transform target;

    private void Start()
    {
        // Destroy the bullet after a certain delay to avoid cluttering the scene
        Destroy(gameObject, destroyDelay);
    }

    private void Update()
    {
        if (target != null)
        {
            MoveTowardsTarget();
        }
    }

    private void MoveTowardsTarget()
    {
        // Lerp towards the target position
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
    }
}
