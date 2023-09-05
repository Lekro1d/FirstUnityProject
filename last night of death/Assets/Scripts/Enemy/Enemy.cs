using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _health;
    private Animator _animator;
    public Player Target => _player;
    public int EHealth => _health;
    public void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Destroy(gameObject, 7);
        }
    }
}
