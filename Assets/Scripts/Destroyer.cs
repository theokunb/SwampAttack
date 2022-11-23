using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<Bullet>(out Bullet bullet))
        {
            Destroy(bullet.gameObject);
        }
    }
}
