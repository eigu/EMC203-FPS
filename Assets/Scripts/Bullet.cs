using UnityEngine;

public class Bullet : Entity
{
    private InputManager inputManager;

    [SerializeField] private float speed;
    [SerializeField] private float destroyDelay;

    private Vector3 target;

    private void Awake()
    {
        inputManager = InputManager.Instance;
    }

    private void Start()
    {
        target = inputManager.GetCrosshairPoint();

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

        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * speed);
    }
}
