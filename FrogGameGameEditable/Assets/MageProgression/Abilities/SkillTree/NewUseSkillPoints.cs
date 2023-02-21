using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewUseSkillPoints : MonoBehaviour
{
    //level window
    public GameObject LevelWindowObject;
    private LevelWindow levelWindow;

    //game object
    //public GameObject DeactivateFireDiciplineUnlessUnlocked;

    // fire dicipline
        // level 2
    //private DeactivateFireMageButton deactivateFireMageButton;
    public GameObject SetFireMageActive;


    //level 3 
    public GameObject SetFlameThrowerActive;
    public GameObject SetFireBallActive;
    public GameObject SetFireVolleyActive;

    // level 4 -- L=left, M=middle, R=right   1,2,3 = left right middle option of each tree side
    // alos, A=1 B=2 C=3 D=4 E=5
    public GameObject DL1;
    public GameObject DL2;    
    
    public GameObject DM1;
    public GameObject DM2;
    public GameObject DM3;    
    
    public GameObject DR1;
    public GameObject DR2;

    // level 5L
    public GameObject EL1;
    public GameObject EL2;
    public GameObject EL3;

    // level 5M
    public GameObject EM1;
    public GameObject EM2;
    public GameObject EM3;
    public GameObject EM4;

    // level 5R
    public GameObject ER1;
    public GameObject ER2;
    public GameObject ER3;

    // level 6L
    public GameObject FL1;
    public GameObject FL2;
    public GameObject FL3;

    // level 6M
    public GameObject FM1;
    public GameObject FM2;
    public GameObject FM3;
    public GameObject FM4;
    public GameObject FM5;
    public GameObject FM6;

    // level 6R
    public GameObject FR1;
    public GameObject FR2;
    public GameObject FR3;


    void Awake()
    {
        levelWindow = LevelWindowObject.GetComponent<LevelWindow>();

        // fire dicipline
        //deactivateFireMageButton = DeactivateFireDiciplineUnlessUnlocked.GetComponent<DeactivateFireMageButton>();
    }


    //fire Dicipline
    public void UnlockFireMage()
    {

        SetFireMageActive.gameObject.SetActive(true);

        //this if statement below forces the previouse to be unlocked before you can unlock

        //if (deactivateIntenseLaserButton.enabled == false)
        //{

        //}

        //if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        //{
        //deactivateFireMageButton.enabled = false;
        //SetFireMageActive.gameObject.SetActive(true);

        //levelWindow.TakeExperiencePoint();

        //print("You are Fire Mage");

        //}
    }

    // level 3
    public void UnlockFlameThrower()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            SetFlameThrowerActive.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();

        }
    }

    public void UnlockFireBall()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            SetFireBallActive.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();

        }
    }

    public void UnlockFireVolley()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            SetFireVolleyActive.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();

        }
    }

    // level 4 Left

    public void Unlock4L1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            DL1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock4L2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            DL2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    // level 4 Middle

    public void Unlock4M1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            DM1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock4M2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            DM2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock4M3()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            DM3.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    // level 4 Right

    public void Unlock4R1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            DR1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock4R2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            DR2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    // level 5 Left

    public void Unlock5L1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            EL1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock5L2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            EL2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock5L3()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            EL3.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    // level 5 middle

    public void Unlock5M1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            EM1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock5M2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            EM2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock5M3()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            EM3.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock5M4()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            EM4.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    // level 5 right

    public void Unlock5R1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            ER1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock5R2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            ER2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock5R3()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            ER3.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    // level 6 Left
    public void Unlock6L1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FL1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6L2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FL2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6L3()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FL3.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    // level 6 Middle

    public void Unlock6M1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FM1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6M2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FM2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6M3()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FM3.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6M4()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FM4.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6M5()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FM5.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6M6()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FM6.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    // level 6 Right

    public void Unlock6R1()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FR1.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6R2()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FR2.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }

    public void Unlock6R3()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            FR3.gameObject.SetActive(true);

            levelWindow.TakeExperiencePoint();
        }
    }
}
