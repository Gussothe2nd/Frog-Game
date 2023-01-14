using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class AbilityList : MonoBehaviour
{
    //abilities that come out of player position

    [SerializeField] public Transform pfFireBlast;
    [SerializeField] public Transform SpawnFireBlastPos;

    //abilities that require aim position and weapon location

    [SerializeField] public GameObject SpawnBeam;
    [SerializeField] public GameObject pfBeam;
    //[SerializeField] public GameObject BeamDamage;

}