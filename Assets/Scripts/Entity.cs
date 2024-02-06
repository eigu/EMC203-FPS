using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected float speed;

    protected virtual void Start()
    {
        health = 1;
    }

    protected virtual void Damage(int damage)
    {
        health -= damage;

        if (health <= 0) Destroy(gameObject);
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.tag != gameObject.tag) Damage(1);
        Debug.Log("hit!");
    }
}
