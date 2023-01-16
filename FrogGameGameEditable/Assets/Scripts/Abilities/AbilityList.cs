using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class AbilityList : MonoBehaviour
{
    //abilities that come out of player position

    [SerializeField] public GameObject pfFireBlast;
    [SerializeField] public Transform SpawnFireBlastPos;

    //abilities that require aim position and weapon location

    //[SerializeField] public GameObject SpawnAbilityProjectile;
    [SerializeField] public GameObject pfBeam;

    [SerializeField] public Transform SpawnInFrontOfCharacterAbility;
    [SerializeField] public GameObject pfFireWall;


}