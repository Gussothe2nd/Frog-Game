using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTest : MonoBehaviour
{
    [SerializeField] private StageWindow stageWindow;
    [SerializeField] private RecieveStageSystem player;

    private void Awake()
    {
        StageSystem stageSystem = new StageSystem();

        stageWindow.SetStageSystem(stageSystem);
        player.SetStageSystem(stageSystem);

    }
}
