using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UI_SkillTree : MonoBehaviour
{

    //player reference
    public GameObject player;

    //get ability holder refernces

    //ability slot 1
    private FireBlastAbilityHolder fireBlastAbilityHolder;
    public GameObject fireBlastAbilityVisualCooldown;

    //ability slot 2

    private WallForceFieldAbilityHolder wallForceFieldAbilityHolder;
    public GameObject wallForceFieldAbilityVisualCooldown;

    private DomeForceFieldAbilityHolder domeForceFieldAbilityHolder;
    public GameObject domeForceFieldAbilityVisualCooldown;

    //private PersonalForceFieldAbilityHolder personalForceFieldAbilityHolder;
    //public GameObject personalForceFieldAbilityVisualCooldown;

    //ability slot 3
    private LaserBeamAbilityHolder laserBeamAbilityHolder;
    public GameObject laserBeamAbilityVisualCooldown;

    private IntenseLaserBeamAbilityHolder intenseLaserBeamAbilityHolder;
    public GameObject intenselaserBeamAbilityVisualCooldown;

    //private ChargeUpLaserBeamAbilityHolder chargeUpLaserBeamAbilityHolder;
    //public GameObject ChargeUplaserBeamAbilityVisualCooldown;

    public void Awake()
    {
        //ability slot 1
        fireBlastAbilityHolder = player.GetComponent<FireBlastAbilityHolder>();

        //ability slot 2

        wallForceFieldAbilityHolder = player.GetComponent<WallForceFieldAbilityHolder>();

        domeForceFieldAbilityHolder = player.GetComponent<DomeForceFieldAbilityHolder>();

        //personalForceFieldAbilityHolder = player.GetComponent<PersonalForceFieldAbilityHolder>();

        //ability slot 3
        laserBeamAbilityHolder = player.GetComponent<LaserBeamAbilityHolder>();

        intenseLaserBeamAbilityHolder = player.GetComponent<IntenseLaserBeamAbilityHolder>();

        //chargeUpLaserBeamAbilityHolder = player.GetComponent<ChargeUpLaserBeamAbilityHolder>();
    }

    //ability slot 1
    public void EnableFireBlastAbility()
    {
        fireBlastAbilityHolder.enabled = true;
        fireBlastAbilityVisualCooldown.gameObject.SetActive(true);
    }

    //ability slot 2

    public void EnableWallForceFieldAbility()
    {
        
        wallForceFieldAbilityHolder.enabled = true;
        wallForceFieldAbilityVisualCooldown.gameObject.SetActive(true);

        //disable others
        domeForceFieldAbilityHolder.enabled = false;
        domeForceFieldAbilityVisualCooldown.gameObject.SetActive(false);

        //personalForceFieldAbilityHolder.enabled = false;
        //personalForceFieldAbilityVisualCooldown.gameObject.SetActive(false);

    }

    public void EnableDomeForceFieldAbility()
    {
        domeForceFieldAbilityHolder.enabled = true;
        domeForceFieldAbilityVisualCooldown.gameObject.SetActive(true);

        //disable others
        wallForceFieldAbilityHolder.enabled = false;
        wallForceFieldAbilityVisualCooldown.gameObject.SetActive(false);

        //personalForceFieldAbilityHolder.enabled = false;
        //personalForceFieldAbilityVisualCooldown.gameObject.SetActive(false);
    }

    //public void EnablePersonalForceFieldAbility()
   //{
        //personalForceFieldAbilityHolder.enabled = true;
        //personalForceFieldAbilityVisualCooldown.gameObject.SetActive(true);

        //disable others
        //wallForceFieldAbilityHolder.enabled = false;
        //wallForceFieldAbilityVisualCooldown.gameObject.SetActive(false);

        //domeForceFieldAbilityHolder.enabled = false;
        //domeForceFieldAbilityVisualCooldown.gameObject.SetActive(false);
    //}
    //ability slot 3
    public void EnableLaserBeamAbility()
    {
        laserBeamAbilityHolder.enabled = true;
        laserBeamAbilityVisualCooldown.gameObject.SetActive(true);

        //disable others
        intenseLaserBeamAbilityHolder.enabled = false;
        intenselaserBeamAbilityVisualCooldown.gameObject.SetActive(false);

        //chargeUpLaserBeamAbilityHolder.enabled = false;
        //ChargeUplaserBeamAbilityVisualCooldown.gameObject.SetActive(false);
    }

    public void EnableIntenseLaserBeamAbility()
    {
        intenseLaserBeamAbilityHolder.enabled = true;
        intenselaserBeamAbilityVisualCooldown.gameObject.SetActive(true);

        //disable others
        laserBeamAbilityHolder.enabled = false;
        laserBeamAbilityVisualCooldown.gameObject.SetActive(false);

        //chargeUpLaserBeamAbilityHolder.enabled = false;
        //ChargeUplaserBeamAbilityVisualCooldown.gameObject.SetActive(false);
    }

    //public void EnableChargeUpLaserBeamAbility()
    //{
        //chargeUpLaserBeamAbilityHolder.enabled = true;
        //ChargeUplaserBeamAbilityVisualCooldown.gameObject.SetActive(true);

        //disable others
        //laserBeamAbilityHolder.enabled = false;
        //laserBeamAbilityVisualCooldown.gameObject.SetActive(false);

        //intenseLaserBeamAbilityHolder.enabled = false;
        //intenselaserBeamAbilityVisualCooldown.gameObject.SetActive(false);
    //}
}
