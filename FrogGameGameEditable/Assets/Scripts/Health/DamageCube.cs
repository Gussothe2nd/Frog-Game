using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCube : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider col)
    {
        if (col.TryGetComponent<Health>(out var health))
        health.Damage(10);

    }

    
    
}
