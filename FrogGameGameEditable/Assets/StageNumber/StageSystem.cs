using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSystem
{
    public event EventHandler OnEnemyQuantityChanged;
    public event EventHandler OnStageChanged;

    private int stage;
    private int enemiesKilled;
    private int enemiesInStage;

    public StageSystem()
    {
        stage = 0;
        enemiesKilled = 0;
        enemiesInStage = 100;
    }

    public void EnemyKilled(int amount)
    {
        enemiesKilled += amount;
        while (enemiesKilled >= enemiesInStage)
        {
            //enough experience to level up
            stage++;
            enemiesKilled -= enemiesInStage;
            if (OnStageChanged != null) OnStageChanged(this, EventArgs.Empty);
        }
        if (OnEnemyQuantityChanged != null) OnEnemyQuantityChanged(this, EventArgs.Empty);
    }

    public void TakeStage(int amount)
    {
        //experience -= amount;

        stage -= amount;

        if (OnStageChanged != null) OnStageChanged(this, EventArgs.Empty);
    }


    public int GetStageNumber()
    {
        return stage;
    }

    public float GetEnemiesKilledNormalized()
    {
        return (float)enemiesKilled / enemiesInStage;
    }
}
