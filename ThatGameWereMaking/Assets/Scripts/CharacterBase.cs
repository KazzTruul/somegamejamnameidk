using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    [SerializeField]
    private int _maxHealth;
    [SerializeField]
    protected float _movementSpeed;

    private float _currentHealth;

    protected abstract void Attack();

    protected virtual void Update()
    {

    }

    private void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    protected abstract void Die();
}