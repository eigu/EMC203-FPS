using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private float speed = 5f;

    private Transform player;

    private void Start()
    {
        player = Camera.main.transform;
    }

    private void Update()
    {
        MoveTowardsPlayer();
    }

    private void MoveTowardsPlayer()
    {
        // Move towards the player's position
        transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * speed);
    }
}
