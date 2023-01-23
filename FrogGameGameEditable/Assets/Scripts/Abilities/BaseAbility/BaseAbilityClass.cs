using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAbilityClass : ScriptableObject
{

    public new string name;
    public float cooldownTime;
    public float activeTime;

    public virtual void Activate(GameObject parent) {}
    //public virtual void BeginCooldown(GameObject parent) {}
    public virtual void ActivateMultiple(GameObject parent) {}
    public virtual void DestroyObject(GameObject parent) {}


}
