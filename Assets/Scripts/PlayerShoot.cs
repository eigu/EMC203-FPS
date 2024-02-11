using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;

    [SerializeField] float fireRate;
    private float timeToShoot;

    private void Start()
    {
        timeToShoot = fireRate;
    }

    private void Update()
    {
        timeToShoot -= Time.deltaTime;

        Shoot();
    }

    private void Shoot()
    {
        bool isPlayerShooting = InputManager.Instance.CheckIfPlayerIsShooting();

        if (isPlayerShooting
            && timeToShoot <= 0)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);

            timeToShoot = fireRate;
        }
    }
}
