using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieveStageSystem : MonoBehaviour
{
    private StageSystem stageSystem;

    //public enum Equip

    public void SetStageSystem(StageSystem stageSystem)
    {
        this.stageSystem = stageSystem;

        stageSystem.OnStageChanged += StageSystem_OnStageChanged;
    }

    private void StageSystem_OnStageChanged(object sender, EventArgs e)
    {
        Debug.Log("Stage Changed");
    }

}
