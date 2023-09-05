using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private int _health;
    
    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _health;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        
        if(_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
