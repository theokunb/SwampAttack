using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Missile : Bullet
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(Damage);
            IsHitted = true;

            _animator.SetTrigger(AnimatorMissile.Params.Hit);
        }
    }

    private void ExplosionEnded()
    {
        Destroy(gameObject);
    }
}
