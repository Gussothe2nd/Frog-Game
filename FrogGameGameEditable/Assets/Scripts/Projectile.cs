using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EnemyOne;

public class Projectile : MonoBehaviour
{
    private Rigidbody bulletRigidbody;

    EnemyOne TakeDamage;

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 10f;
        bulletRigidbody.velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider triggerCollider)
    {

        if(triggerCollider.gameObject.TryGetComponent<EnemyOne>(out EnemyOne enemyComponent))
        {
            enemyComponent.TakeDamage(20);
        }

        print(triggerCollider.gameObject.name);
        Destroy(gameObject);
    }
}
