using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableUpgradeLayer : MonoBehaviour
{
    //stage window
    public GameObject StageWindowObject;
    private StageWindow stageWindow;

    //Upgrade Buttons being set active

    // Stage 2
    public GameObject FireEffect;

    //level 3 
    public GameObject Level3;

    // level 4
    public GameObject Level4;

    // level 5L
    public GameObject Level5;

    // level 6L
    public GameObject Level6;

    // level 6L M R

    enum Level6LMR 
    
    { 
        FL1 = 1,
        FL2,
        FL3,
    }

    public GameObject FL1;
    public GameObject FL2;
    public GameObject FL3;

    public GameObject FM1;
    public GameObject FM2;
    public GameObject FM3;
    public GameObject FM4;
    public GameObject FM5;
    public GameObject FM6;

    public GameObject FR1;
    public GameObject FR2;
    public GameObject FR3;


 
    void Start()
    {
        // generate random number (Level 6L) or do this in each layer for extra randomness

    }
    

    void Awake()
    {
        stageWindow = StageWindowObject.GetComponent<StageWindow>();
    }

    void Update()
    {
        // Layer 2

        if (stageWindow.stageSystem.GetStageNumber() == 2)
        {
            FireEffect.gameObject.SetActive(true);

            return;
        }

        //Layer 3
        if (stageWindow.stageSystem.GetStageNumber() == 3)
        {
            Level3.gameObject.SetActive(true);

            return;
        }

        //Layer 4
        if (stageWindow.stageSystem.GetStageNumber() == 4)
        {
            Level4.gameObject.SetActive(true);

            return;
        }

        //Layer 5
        if (stageWindow.stageSystem.GetStageNumber() == 5)
        {
            Level5.gameObject.SetActive(true);

            return;
        }

        //Layer 6
        if (stageWindow.stageSystem.GetStageNumber() == 6)
        {
            Level6.gameObject.SetActive(true);

            //random.range of level 6 L M R 
            // number chosen equals 

            //generate random number between 1-3
            // exclude that number / corresponding upgrade
        }

    }
}
