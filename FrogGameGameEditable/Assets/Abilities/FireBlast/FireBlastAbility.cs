using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FireBlastAbility : BaseAbilityClass
{

    public float FireBlastRange;
    //public AbilityVisual CoolDownVisual;

    private GameObject SpawnedFireBlast;

    public override void Activate(GameObject parent)
    {
        //Instantiate(pfFireBlast, SpawnFireBlastPos.position, SpawnFireBlastPos.rotation);

        AbilityList abilityList = parent.GetComponent<AbilityList>();

        SpawnedFireBlast = Instantiate(abilityList.pfFireBlast, abilityList.SpawnPlayerPos.position, abilityList.SpawnPlayerPos.rotation) as GameObject;

    }

    public override void DestroyObject(GameObject parent)
    {
        Destroy(SpawnedFireBlast);
    }

}
