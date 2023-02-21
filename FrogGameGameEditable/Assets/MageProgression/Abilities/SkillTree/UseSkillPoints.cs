using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSkillPoints : MonoBehaviour
{
    //level window
    public GameObject LevelWindowObject;
    private LevelWindow levelWindow;

    //game object
    //public GameObject DeactivateUnlessUnlocked;
    public GameObject DeactivateFireDiciplineUnlessUnlocked;


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

    // fire dicipline
    private DeactivateFireMageButton deactivateFireMageButton;
    public GameObject SetFireMageActive;

    void Awake()
    {
        levelWindow = LevelWindowObject.GetComponent<LevelWindow>();

        //deactivateHealButton = DeactivateUnlessUnlocked.GetComponent<DeactivateHealButton>();
        //deactivateLongHealButton = DeactivateUnlessUnlocked.GetComponent<DeactivateLongHealButton>();
        //deactivateSuperHealButton = DeactivateUnlessUnlocked.GetComponent<DeactivateSuperHealButton>();

        //deactivateWallShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivateWallShieldButton>();
        //deactivateDomeShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivateDomeShieldButton>();
        //deactivatePersonalShieldButton = DeactivateUnlessUnlocked.GetComponent<DeactivatePersonalShieldButton>();

        //deactivateLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateLaserButton>();
        //deactivateIntenseLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateIntenseLaserButton>();
        //deactivateChargeLaserButton = DeactivateUnlessUnlocked.GetComponent<DeactivateChargeLaserButton>();

        // fire dicipline
        deactivateFireMageButton = DeactivateFireDiciplineUnlessUnlocked.GetComponent<DeactivateFireMageButton>();
    }

    //Base Left Column

    //public void UnlockHeal()
    //{

    //if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    //{
    //deactivateHealButton.enabled = false;
    //SetHealActive.gameObject.SetActive(true);

    //levelWindow.TakeExperiencePoint();

    //print("sheesh");
    //}
    //}

    //public void UnlockLongHeal()
    //{

    //if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    //{
    //deactivateLongHealButton.enabled = false;
    //SetLongHealActive.gameObject.SetActive(true);

    //levelWindow.TakeExperiencePoint();

    //print("sheesh");
    //}
    //}

    // public void UnlockSuperHeal()
    //{

    //if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    //{
    //deactivateSuperHealButton.enabled = false;
    //SetSuperHealActive.gameObject.SetActive(true);

    //levelWindow.TakeExperiencePoint();

    // print("sheesh");
    // }
    //}

    //Base Middle Column
    //public void UnlockWallShield()
    // {
    //
    // if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    //{
    // deactivateWallShieldButton.enabled = false;
    // SetWallShieldActive.gameObject.SetActive(true);

    // levelWindow.TakeExperiencePoint();

    //    print("sheesh");
    //  }
    //}

    //public void UnlockDomeShield()
    //{
    //this if statement below forces the previouse to be unlocked before you can unlock

    //if (deactivateWallShieldButton.enabled == false)
    //{

    //}


    //if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    //  {
    //   deactivateDomeShieldButton.enabled = false;
    //  SetDomeShieldActive.gameObject.SetActive(true);
    //
    //   levelWindow.TakeExperiencePoint();

    //   print("sheesh");
    //}
    //}

    // public void UnlockPersonalShield()
    // {

    //this if statement below forces the previouse to be unlocked before you can unlock

    //if (deactivateDomeShieldButton.enabled == false)
    //{

    //}

    // if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    // {
    // deactivatePersonalShieldButton.enabled = false;
    //SetPersonalShieldActive.gameObject.SetActive(true);

    // levelWindow.TakeExperiencePoint();

    // print("sheesh");
    // }
    //}

    //Base Right Column

    // public void UnlockLaser()
    //{


    //if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    //{
    //  deactivateLaserButton.enabled = false;
    // SetLaserActive.gameObject.SetActive(true);

    //   levelWindow.TakeExperiencePoint();

    //  print("sheesh");
    //  }
    //}

    // public void UnlockIntenseLaser()
    //{
    //this if statement below forces the previouse to be unlocked before you can unlock

    //if (deactivateLaserButton.enabled == false)
    //{

    //}


    // if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    //{
    //  deactivateIntenseLaserButton.enabled = false;
    //  SetIntenseLaserActive.gameObject.SetActive(true);

    // levelWindow.TakeExperiencePoint();

    //  print("sheesh");
    //  }
    // }

    //public void UnlockChargeLaser()
    // {
    //this if statement below forces the previouse to be unlocked before you can unlock

    //if (deactivateIntenseLaserButton.enabled == false)
    //{

    //}

    //if (levelWindow.levelSystem.GetLevelNumber() >= 0)
    // {
    //   deactivateChargeLaserButton.enabled = false;
    //   SetChargeLaserActive.gameObject.SetActive(true);

    // levelWindow.TakeExperiencePoint();

    //   print("sheesh");
    // }
    //}

    //fire Dicipline
    public void UnlockFireMage()
    {
        //this if statement below forces the previouse to be unlocked before you can unlock

        //if (deactivateIntenseLaserButton.enabled == false)
        //{

        //}

        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            deactivateFireMageButton.enabled = false;
            SetFireMageActive.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();

            print("You are Fire Mage");

        }
    }
}