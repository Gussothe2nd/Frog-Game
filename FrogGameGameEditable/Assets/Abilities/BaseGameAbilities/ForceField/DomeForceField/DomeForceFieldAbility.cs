using System.Collections;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Collections.Specialized;
using UnityEngine;

[CreateAssetMenu]
public class DomeForceFieldAbility : BaseAbilityClass
{
    //public AbilityHolder abilityHolder;

    //private void Awake(Component parent)
    //{
    //abilityHolder = parent.GetComponent<AbilityHolder>();
    //}


    //public void EnableAbility(GameObject parent) 
    //{
        //abilityHolder = parent.GetComponent<AbilityHolder>();
        //abilityHolder.enabled = true;
    //}

    public float Range;

    private GameObject SpawnedForceField;

    public override void Activate(GameObject parent)
    {

        AbilityList abilityList = parent.GetComponent<AbilityList>();

        SpawnedForceField = Instantiate(abilityList.pfForceField, abilityList.SpawnPlayerPos.position, abilityList.SpawnPlayerPos.rotation) as GameObject;

    }

    public override void DestroyObject(GameObject parent)
    {
        Destroy(SpawnedForceField);
    }

}
