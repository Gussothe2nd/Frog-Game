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

    //ability slot 2->3
    //public GameObject

    void Awake()
    {
        deactivateWallShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivateWallShieldButton>();
        deactivateDomeShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivateDomeShieldButton>();
        deactivatePersonalShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivatePersonalShieldButton>();
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
}
