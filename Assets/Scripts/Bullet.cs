using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] protected int Damage;
    [SerializeField] protected float Speed;

    protected bool IsHitted;

    private void Awake()
    {
        IsHitted = false;
        StartCoroutine(Fly());

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(Damage);
            IsHitted = true;

            Destroy(gameObject);
        }
    }

    private IEnumerator Fly()
    {
        while(IsHitted == false)
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime, Space.World);
            yield return null;
        }
    }
}
