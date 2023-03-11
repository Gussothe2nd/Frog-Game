//using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

    public GameObject DL1;
    public GameObject DL2;

    public GameObject DM1;
    public GameObject DM2;
    public GameObject DM3;

    public GameObject DR1;
    public GameObject DR2;

    public GameObject EL1;
    public GameObject EL2;
    public GameObject EL3;

    public GameObject EM1;
    public GameObject EM2;
    public GameObject EM3;
    public GameObject EM4;

    public GameObject ER1;
    public GameObject ER2;
    public GameObject ER3;


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

    //bools

    public bool randomUpgradeExcluder = false;

    public bool leftNumberAlreadyChosen = false;
    public bool middleNumberAlreadyChosen = false;
    public bool rightNumberAlreadyChosen = false;

    public bool level4to5NumberReset = true;
    public bool level5to6NumberReset = true;

    public void resetNumberAlreadyUsedBool()
    {
        leftNumberAlreadyChosen = false;
        middleNumberAlreadyChosen = false;
        rightNumberAlreadyChosen = false;
    }

    public int LeftNumber;


    public int ELeftMiddleNumber;
    public int ERightMiddleNumber;

    public int MiddleNumber;

    public int FLeftMiddleNumber; 
    public int FRightMiddleNumber;


    public int RightNumber;


    public void LeftRandomGenerate()
    {
        LeftNumber = Random.Range(1, 4);
    }

    public void MiddleRandomGenerate()
    {
        ELeftMiddleNumber = Random.Range(1, 3);
        ERightMiddleNumber = Random.Range(3, 5);

        MiddleNumber = Random.Range(1, 4);

        FLeftMiddleNumber = Random.Range(1, 4);
        FRightMiddleNumber = Random.Range(4, 7);

    }

    public void RightRandomGenerate()
    {
        RightNumber = Random.Range(1, 4);
    }
    

    void Awake()
    {
        stageWindow = StageWindowObject.GetComponent<StageWindow>();
    }

    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            randomUpgradeExcluder = true;
        }

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

                // Middle--------------------------------------------------------

                if (randomUpgradeExcluder) 
                {

                    if (!middleNumberAlreadyChosen)
                    {
                        MiddleRandomGenerate();

                        middleNumberAlreadyChosen = true;

                        if (MiddleNumber == 1)
                        {
                            DM1.gameObject.SetActive(false);
                        }

                        if (MiddleNumber == 2)
                        {
                            DM2.gameObject.SetActive(false);
                        }

                        if (MiddleNumber == 3)
                        {
                            DM3.gameObject.SetActive(false);
                        }

                        return;
                    }
                }

                // Right----------------------------------------------------------

                //}
                return;
            }


            //Layer 5

            if (stageWindow.stageSystem.GetStageNumber() == 5 && level4to5NumberReset)
            {
                resetNumberAlreadyUsedBool();

                level4to5NumberReset = false;

                level5to6NumberReset = true;

            }

        if (stageWindow.stageSystem.GetStageNumber() == 5)
        {
                Level5.gameObject.SetActive(true);

            // Left----------------------------------------------------------

            if (randomUpgradeExcluder)
            {

                if (!leftNumberAlreadyChosen)
                {
                            LeftRandomGenerate();

                            leftNumberAlreadyChosen = true;

                            if (LeftNumber == 1)
                            {
                                EL1.gameObject.SetActive(false);
                            }

                            if (LeftNumber == 2)
                            {
                                EL2.gameObject.SetActive(false);
                            }

                            if (LeftNumber == 3)
                            {
                                EL3.gameObject.SetActive(false);
                            }

                            return;
                }

                        // Middle--------------------------------------------------------

                if (!middleNumberAlreadyChosen)
                {
                    MiddleRandomGenerate();

                    middleNumberAlreadyChosen = true;

                    // 5 Middle Left
                    if (ELeftMiddleNumber == 1)
                    {
                        EM1.gameObject.SetActive(false);
                    }

                    if (ELeftMiddleNumber == 2)
                    {
                    EM2.gameObject.SetActive(false);
                    }

                            // 5 Middle Right
                            if (ERightMiddleNumber == 3)
                            {
                                EM3.gameObject.SetActive(false);
                            }

                            if (ERightMiddleNumber == 4)
                            {
                                EM4.gameObject.SetActive(false);
                            }

                            return;
                }


                        // Right------------------------------------------------------

                        if (!rightNumberAlreadyChosen)
                        {
                            RightRandomGenerate();

                            rightNumberAlreadyChosen = true;

                            if (RightNumber == 1)
                            {
                                ER1.gameObject.SetActive(false);
                            }

                            if (RightNumber == 2)
                            {
                                ER2.gameObject.SetActive(false);
                            }

                            if (RightNumber == 3)
                            {
                                ER3.gameObject.SetActive(false);
                            }

                            return;
                }

               return;
            }
        }

            //Layer 6

            if (stageWindow.stageSystem.GetStageNumber() == 6 && level5to6NumberReset)
            {
                resetNumberAlreadyUsedBool();

                level5to6NumberReset = false;

                //level6to7NumberReset = true;

            }

        // if stage number changes, number already chosen = false
        if (stageWindow.stageSystem.GetStageNumber() == 6)
        {
            Level6.gameObject.SetActive(true);

            // Left----------------------------------------------------------
            if (randomUpgradeExcluder)
            {

                if (!leftNumberAlreadyChosen)
                {
                    LeftRandomGenerate();

                    leftNumberAlreadyChosen = true;

                    if (LeftNumber == 1)
                    {
                        FL1.gameObject.SetActive(false);
                    }

                    if (LeftNumber == 2)
                    {
                        FL2.gameObject.SetActive(false);
                    }

                    if (LeftNumber == 3)
                    {
                        FL3.gameObject.SetActive(false);
                    }

                    return;
                }

                // Middle--------------------------------------------------------

                if (!middleNumberAlreadyChosen)
                {
                    MiddleRandomGenerate();

                    middleNumberAlreadyChosen = true;

                    // 6 Middle Left
                    if (FLeftMiddleNumber == 1)
                    {
                        FM1.gameObject.SetActive(false);
                    }

                    if (FLeftMiddleNumber == 2)
                    {
                        FM2.gameObject.SetActive(false);
                    }

                    if (FLeftMiddleNumber == 3)
                    {
                        FM3.gameObject.SetActive(false);
                    }

                    // 6 Middle Right
                    if (FRightMiddleNumber == 4)
                    {
                        FM4.gameObject.SetActive(false);
                    }

                    if (FRightMiddleNumber == 5)
                    {
                        FM5.gameObject.SetActive(false);
                    }

                    if (FRightMiddleNumber == 6)
                    {
                        FM6.gameObject.SetActive(false);
                    }

                    return;
                }

                // Right----------------------------------------------------------

                if (!rightNumberAlreadyChosen)
                {
                    RightRandomGenerate();

                    rightNumberAlreadyChosen = true;

                    if (RightNumber == 1)
                    {
                        FR1.gameObject.SetActive(false);
                    }

                    if (RightNumber == 2)
                    {
                        FR2.gameObject.SetActive(false);
                    }

                    if (RightNumber == 3)
                    {
                        FR3.gameObject.SetActive(false);
                    }

                    return;

                }

            }

        }
       
    }
}
