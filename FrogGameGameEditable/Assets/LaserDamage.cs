using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDamage : MonoBehaviour
{

    //[SerializeField] public LayerMask LaserColliderLayerMask = new LayerMask();

    EnemyOne TakeDamage;

    private Rigidbody LaserDamageRigidbody;

    private void Awake()
    {
        LaserDamageRigidbody = GetComponent<Rigidbody>();
    }

    //public GameObject Laser2

    void Start()
    {
        //Physics.IgnoreLayerCollision(0, 2);
    }

    void OnTriggerEnter(Collider triggerCollider)
    {


        if (triggerCollider.gameObject.TryGetComponent<EnemyOne>(out EnemyOne enemyComponent))
        {
            enemyComponent.TakeDamage(20);
        }
        //Physics.IgnoreLayerCollision(0, 2);

        print(triggerCollider.gameObject.name);

    }
}
