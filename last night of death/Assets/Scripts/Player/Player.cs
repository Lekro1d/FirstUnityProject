using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _currentHealth;
    private Animator _animator;
    public int PHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = _health;
        _animator = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        _animator.SetTrigger("Hurt");
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            _animator.SetTrigger("Death");
            Die();
        }
    }

    public void Die()
    {
        //Destroy(gameObject, 7f);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
