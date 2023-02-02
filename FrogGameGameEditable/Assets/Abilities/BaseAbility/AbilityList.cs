using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class AbilityList : MonoBehaviour
{
    //abilities that come out of player position

    [SerializeField] public Transform SpawnPlayerPos;

    //ability slot 1
    [SerializeField] public GameObject pfFireBlast;

    //ability slot 2
    [SerializeField] public GameObject pfForceField;

    //ability slot 3


    //abilities that require aim position and weapon location


    [SerializeField] public Transform SpawnInFrontOfCharacterAbility;

    //ability slot 1

    //ability slot 2
    [SerializeField] public GameObject pfWallForceField;

    //ability slot 3
    [SerializeField] public GameObject pfBeam;

    [SerializeField] public GameObject pfFireWall;


}