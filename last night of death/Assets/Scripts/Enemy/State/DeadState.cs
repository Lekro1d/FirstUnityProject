using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : State
{
    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnEnable()
    {
        _animator.Play("Dead");  
    }

    private void OnDisable()
    {
        _animator.StartPlayback();
    }
}
