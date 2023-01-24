using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieveLevelSystem : MonoBehaviour
{
    private LevelSystem levelSystem;

    //public enum Equip

    public void SetLevelSystem(LevelSystem levelSystem)
    {
        this.levelSystem = levelSystem;

        levelSystem.OnLevelChanged += LevelSystem_OnLevelChanged;
    }

    private void LevelSystem_OnLevelChanged(object sender, EventArgs e)
    {
        Debug.Log("Level Up");
    }

    public KeyCode key;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Debug.Log("Level Up");
        }
    }
}
