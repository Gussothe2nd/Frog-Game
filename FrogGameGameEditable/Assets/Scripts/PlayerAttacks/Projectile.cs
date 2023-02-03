using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static EnemyOne; don't seem to need this

public class Projectile : MonoBehaviour
{
    private Rigidbody bulletRigidbody;

    HealthAmount TakeDamage;

    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        Physics.IgnoreLayerCollision(8 , 9);
    }

    private void Update()
    {
        Physics.IgnoreLayerCollision(8, 9);
    }

    private void Start()
    {
        float speed = 10f;
        bulletRigidbody.velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider triggerCollider)
    {

        if(triggerCollider.gameObject.TryGetComponent<HealthAmount>(out HealthAmount enemyComponent))
        {
            enemyComponent.TakeDamage(20);
        }

        print(triggerCollider.gameObject.name);
        Destroy(gameObject);
    }
}
