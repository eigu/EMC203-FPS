using UnityEngine;

public class Player: Entity
{
    private InputManager inputManager;

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletSpawn;

    private void Start()
    {
        inputManager = InputManager.Instance;

        health = 10;
    }

    private void Update()
    {
        Shoot();
        Debug.Log(inputManager.CheckIfPlayerIsShooting());
    }

    private void Shoot()
    {
        bool isPlayerShooting = inputManager.CheckIfPlayerIsShooting();

        if (isPlayerShooting)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        }
    }
}
