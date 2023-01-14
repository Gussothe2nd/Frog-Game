using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDamage : MonoBehaviour
{

    EnemyOne TakeDamage;

    private Rigidbody LaserDamageRigidbody;

    private void Awake()
    {
        LaserDamageRigidbody = GetComponent<Rigidbody>();
    }

    //public GameObject Laser2

    void start()
    {
        Physics.IgnoreLayerCollision(0, 2);
    }

    void OnTriggerEnter(Collider triggerCollider)
    {
        //Laser2 = GetGameObject
        //Physics.IgnoreCollision

        if (triggerCollider.gameObject.TryGetComponent<EnemyOne>(out EnemyOne enemyComponent))
        {
            enemyComponent.TakeDamage(20);
        }

        print(triggerCollider.gameObject.name);

    }
}
