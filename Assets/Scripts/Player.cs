using UnityEngine;

public class Player : Entity
{
    private InputManager inputManager;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;

    [SerializeField] float fireRate;
    private float timeToShoot;

    private void Awake()
    {
        inputManager = InputManager.Instance;
    }

    protected override void Start()
    {
        health = 10;
        timeToShoot = fireRate;
    }

    private void Update()
    {
        timeToShoot -= Time.deltaTime;

        Shoot();
    }

    private void Shoot()
    {
        bool isPlayerShooting = inputManager.CheckIfPlayerIsShooting();

        if (isPlayerShooting
            && timeToShoot <= 0)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);

            timeToShoot = fireRate;
        }
    }
}
