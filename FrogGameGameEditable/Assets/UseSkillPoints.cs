using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSkillPoints : MonoBehaviour
{

    public GameObject DeactivateUnlessUnlocked;

    //ability slot 2
    private DeactivateWallShieldButton deactivateWallShieldButton;
    public GameObject SetWallShieldActive;

    private DeactivateDomeShieldButton deactivateDomeShieldButton;
    public GameObject SetDomeShieldActive;    
    
    private DeactivatePersonalShieldButton deactivatePersonalShieldButton;
    public GameObject SetPersonalShieldActive;

    //ability slot 3
    private DeactivateLaserButton deactivateLaserButton;
    public GameObject SetLaserActive;

    private DeactivateIntenseLaserButton deactivateIntenseLaserButton;
    public GameObject SetIntenseLaserActive;

    private DeactivateChargeLaserButton deactivateChargeLaserButton;
    public GameObject SetChargeLaserActive;

    void Awake()
    {
        deactivateWallShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivateWallShieldButton>();
        deactivateDomeShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivateDomeShieldButton>();
        deactivatePersonalShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivatePersonalShieldButton>();

        deactivateLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateLaserButton>();
        deactivateIntenseLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateIntenseLaserButton>();
        deactivateChargeLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateChargeLaserButton>();
    }
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
        if (deactivateWallShieldButton.enabled == false)
        {
            deactivateDomeShieldButton.enabled = false;
            SetDomeShieldActive.gameObject.SetActive(true);
        }
        

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    public void UnlockPersonalShield()
    {
        if (deactivateDomeShieldButton.enabled == false)
        {
            deactivatePersonalShieldButton.enabled = false;
            SetPersonalShieldActive.gameObject.SetActive(true);
        }

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    //ability slot 3

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
        if (deactivateLaserButton.enabled == false)
        {
            deactivateIntenseLaserButton.enabled = false;
            SetIntenseLaserActive.gameObject.SetActive(true);
        }


        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }

    public void UnlockChargeLaser()
    {
        if (deactivateIntenseLaserButton.enabled == false)
        {
            deactivateChargeLaserButton.enabled = false;
            SetChargeLaserActive.gameObject.SetActive(true);
        }

        //if(XP)
        //{
        // SkillPoint > 0 
        // -1 skillpoint
        // deactivateWallShieldButton = false
        //}
    }
}
