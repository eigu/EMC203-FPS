using UnityEngine;

public class Bullet : Entity
{
    private InputManager inputManager;

    [SerializeField] private float destroyDelay;

    private Vector3 target;

    private void Awake()
    {
        inputManager = InputManager.Instance;
    }

    protected override void Start()
    {
        target = inputManager.GetCrosshairPoint();

        Destroy(gameObject, destroyDelay);
    }

    private void Update()
    {
        MoveTowardsTarget();
    }

    private void MoveTowardsTarget()
    {
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * speed);
    }
}
