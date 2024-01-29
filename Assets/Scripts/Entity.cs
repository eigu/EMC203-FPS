using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected int health = 1;

    public void Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
