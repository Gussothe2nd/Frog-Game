using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTest : MonoBehaviour
{
    [SerializeField] private LevelWindow levelWindow;
    [SerializeField] private RecieveLevelSystem player;

    private void Awake()
    {
        LevelSystem levelSystem = new LevelSystem();
        //Debug.Log(levelSystem.GetLevelNumber());
        //levelSystem.AddExperience(50);
        //Debug.Log(levelSystem.GetLevelNumber());
        //levelSystem.AddExperience(60);
        //Debug.Log(levelSystem.GetLevelNumber());        
        //levelSystem.AddExperience(100);
        //Debug.Log(levelSystem.GetLevelNumber());

        levelWindow.SetLevelSystem(levelSystem);
        player.SetLevelSystem(levelSystem);

    }
}
