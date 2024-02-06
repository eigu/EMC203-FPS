using UnityEngine;

public class Enemy : Entity
{
    private Transform player;

    protected override void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        MoveTowardsPlayer();
    }

    private void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, Time.deltaTime * speed);
    }
}
