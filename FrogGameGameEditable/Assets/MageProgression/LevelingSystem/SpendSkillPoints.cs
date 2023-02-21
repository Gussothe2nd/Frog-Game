using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this is for future spendig skill points on cosmetics in the future
public class SpendSkillPoints : MonoBehaviour
{

    //level window
    public GameObject LevelWindowObject;
    private LevelWindow levelWindow;

    void Awake()
    {
        levelWindow = LevelWindowObject.GetComponent<LevelWindow>();

    }

    void PressButton()
    {
        if (levelWindow.levelSystem.GetLevelNumber() >= 0)
        {
            // do action

            levelWindow.TakeExperiencePoint();

        }
    }
}
