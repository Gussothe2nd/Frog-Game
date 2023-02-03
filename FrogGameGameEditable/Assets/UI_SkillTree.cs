using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UI_SkillTree : MonoBehaviour
{
    //test/learning
    public void Fart()
    {
        print("fart");
    }

    //player reference
    public GameObject player;

    //get ability holder refernces

    //ability slot 1
    private FireBlastAbilityHolder fireBlastAbilityHolder;
    public GameObject fireBlastAbilityVisualCooldown;

    //ability slot 2
    private ForceFieldAbilityHolder forceFieldAbilityHolder;
    public GameObject forceFieldAbilityVisualCooldown;

    //ability slot 2
    private LaserBeamAbilityHolder laserBeamAbilityHolder;
    public GameObject laserBeamAbilityVisualCooldown;

    public void Awake()
    {
        //ability slot 1
        fireBlastAbilityHolder = player.GetComponent<FireBlastAbilityHolder>();
        //ability slot 2
        forceFieldAbilityHolder = player.GetComponent<ForceFieldAbilityHolder>();
        //ability slot 2
        laserBeamAbilityHolder = player.GetComponent<LaserBeamAbilityHolder>();
    }

    //ability slot 1
    public void EnableFireBlastAbility()
    {
        fireBlastAbilityHolder.enabled = true;
        fireBlastAbilityVisualCooldown.gameObject.SetActive(true);
    }
    //ability slot 2
    public void EnableForceFieldAbility()
    {
        forceFieldAbilityHolder.enabled = true;
        forceFieldAbilityVisualCooldown.gameObject.SetActive(true);
    }
    //ability slot 3
    public void EnableLaserBeamAbility()
    {
        laserBeamAbilityHolder.enabled = true;
        laserBeamAbilityVisualCooldown.gameObject.SetActive(true);
    }
}
