using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float _timeShoot;
    [SerializeField] private Transform _shootPoint;

    private float _startShoot = 0f;
    private Animator _animator;

    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Update()
    {
        if (_startShoot <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bulletPrefab, _shootPoint.position, Quaternion.identity);
                _animator.SetTrigger("Shoot");
                _startShoot = _timeShoot;
            }
            _startShoot -= Time.deltaTime;
        }
    }
}
