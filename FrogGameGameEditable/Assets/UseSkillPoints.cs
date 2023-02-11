using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSkillPoints : MonoBehaviour
{

    public GameObject DeactivateUnlessUnlocked;

    //ability Left Column
    private DeactivateHealButton deactivateHealButton;
    public GameObject SetHealActive;

    private DeactivateLongHealButton deactivateLongHealButton;
    public GameObject SetLongHealActive;

    private DeactivateSuperHealButton deactivateSuperHealButton;
    public GameObject SetSuperHealActive;

    //ability Middle Column
    private DeactivateWallShieldButton deactivateWallShieldButton;
    public GameObject SetWallShieldActive;

    private DeactivateDomeShieldButton deactivateDomeShieldButton;
    public GameObject SetDomeShieldActive;    
    
    private DeactivatePersonalShieldButton deactivatePersonalShieldButton;
    public GameObject SetPersonalShieldActive;

    //ability Right Column
    private DeactivateLaserButton deactivateLaserButton;
    public GameObject SetLaserActive;

    private DeactivateIntenseLaserButton deactivateIntenseLaserButton;
    public GameObject SetIntenseLaserActive;

    private DeactivateChargeLaserButton deactivateChargeLaserButton;
    public GameObject SetChargeLaserActive;

    void Awake()
    {
        deactivateHealButton = DeactivateUnlessUnlocked.GetComponent<DeactivateHealButton>();
        deactivateLongHealButton = DeactivateUnlessUnlocked.GetComponent<DeactivateLongHealButton>();
        deactivateSuperHealButton = DeactivateUnlessUnlocked.GetComponent<DeactivateSuperHealButton>();

        deactivateWallShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivateWallShieldButton>();
        deactivateDomeShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivateDomeShieldButton>();
        deactivatePersonalShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivatePersonalShieldButton>();

        deactivateLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateLaserButton>();
        deactivateIntenseLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateIntenseLaserButton>();
        deactivateChargeLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateChargeLaserButton>();

    }

    //Base Left Column

    public void UnlockHeal()
    {
        deactivateHealButton.enabled = false;
        SetHealActive.gameObject.SetActive(true);

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    public void UnlockLongHeal()
    {
        deactivateLongHealButton.enabled = false;
        SetLongHealActive.gameObject.SetActive(true);

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    public void UnlockSuperHeal()
    {
        deactivateSuperHealButton.enabled = false;
        SetSuperHealActive.gameObject.SetActive(true);

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    //Base Middle Column
    public void UnlockWallShield()
    {
        deactivateWallShieldButton.enabled = false;
        SetWallShieldActive.gameObject.SetActive(true);
        
        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    public void UnlockDomeShield()
    {
        //this if statement below forces the previouse to be unlocked before you can unlock

        //if (deactivateWallShieldButton.enabled == false)
        //{
            deactivateDomeShieldButton.enabled = false;
            SetDomeShieldActive.gameObject.SetActive(true);
        //}
        

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    public void UnlockPersonalShield()
    {

        //this if statement below forces the previouse to be unlocked before you can unlock

        //if (deactivateDomeShieldButton.enabled == false)
        //{
        deactivatePersonalShieldButton.enabled = false;
            SetPersonalShieldActive.gameObject.SetActive(true);
        //}

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    //Base Right Column

    public void UnlockLaser()
    {
        deactivateLaserButton.enabled = false;
        SetLaserActive.gameObject.SetActive(true);

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    public void UnlockIntenseLaser()
    {
        //this if statement below forces the previouse to be unlocked before you can unlock

        //if (deactivateLaserButton.enabled == false)
        //{
            deactivateIntenseLaserButton.enabled = false;
            SetIntenseLaserActive.gameObject.SetActive(true);
        //}


        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    public void UnlockChargeLaser()
    {
        //this if statement below forces the previouse to be unlocked before you can unlock

        //if (deactivateIntenseLaserButton.enabled == false)
        //{
            deactivateChargeLaserButton.enabled = false;
            SetChargeLaserActive.gameObject.SetActive(true);
        //}

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }
}
