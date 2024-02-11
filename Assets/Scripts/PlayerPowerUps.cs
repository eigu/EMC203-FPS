using UnityEngine;

public enum PowerUps
{
    Normal,
    AutoAim
}

public class PlayerPowerUps : MonoBehaviour
{
    [SerializeField] private PowerUps powerUp;

    private void Update()
    {
        UsePowerUp(powerUp);
    }

    private void UsePowerUp(PowerUps powerUp)
    {
        bool isPlayerUsingPowerUp = InputManager.Instance.CheckIfPlayerIsUsingPowerUp();

        int currentSP = FindObjectOfType<Player>().currentSP;

        if (!isPlayerUsingPowerUp && currentSP < 5) return;

        switch (powerUp)
        {
            case PowerUps.Normal:
                break;
            case PowerUps.AutoAim:
                //AutoAim();
                break;
        }

    }

    //private void AutoAim()
    //{
    //    Vector2 center = new Vector2(400f, 400f);

    //    Enemy[] enemies = FindObjectsOfType<Enemy>();

    //    foreach (Enemy enemy in enemies)
    //    {
    //        Vector2 enemyScreenPos = Camera.main.WorldToScreenPoint(enemy.transform.position);

    //        float distanceToCenter = Vector2.Distance(center, enemyScreenPos);

    //        if (distanceToCenter <= 400f)
    //        {
    //            AimAndShoot(enemy);
    //        }
    //    }
    //}

    //private void AimAndShoot(Enemy enemy)
    //{
    //    // Aim at the enemy and shoot
    //    // Your aiming and shooting logic goes here
    //}
}
