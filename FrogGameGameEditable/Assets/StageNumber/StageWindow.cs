using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class StageWindow : MonoBehaviour
{

    [SerializeField] private Text stageText;

    [SerializeField] private Slider enemiesKilledBarFill;

    public StageSystem stageSystem;

    public KeyCode key;

    private void Awake()
    {
        stageText = transform.Find("StageDisplayText").GetComponent<Text>();
        
        enemiesKilledBarFill = transform.Find("EnemiesKilledBar").GetComponent<Slider>();

    }

    //method for adding and subtracting skill points
    public void AddEnemyKilled()
    {
        stageSystem.EnemyKilled(50);
    }

    public void TakeStage()
    {
        stageSystem.TakeStage(1);
    }
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            AddEnemyKilled();
        }

        if (Input.GetKeyDown("y"))
        {
            TakeStage();

            print("take level");
        }
    }


    private void SetEnemiesKilledBarSize(float experienceNormalized)
    {
        //experienceBarFill.fillAmount = experienceNormalized;
        enemiesKilledBarFill.value = experienceNormalized * 100f;
    }

    private void SetStageNumber(int stageNumber)
    {
        stageText.text = "STAGE\n" + (stageNumber + 1);
    }


    public void SetStageSystem(StageSystem stageSystem)
    {
        //set the LevelSystem object
        this.stageSystem = stageSystem;

        //Update the starting values
        SetStageNumber(stageSystem.GetStageNumber());
        SetEnemiesKilledBarSize(stageSystem.GetEnemiesKilledNormalized());

        //subscribe to the changed events
        stageSystem.OnEnemyQuantityChanged += StageSystem_OnEnemyQuantityChanged;
        stageSystem.OnStageChanged += StageSystem_OnStageChanged;
    }

    private void StageSystem_OnStageChanged(object sender, System.EventArgs e)
    {
        //level changed, update text
        SetStageNumber(stageSystem.GetStageNumber());
    }

    private void StageSystem_OnEnemyQuantityChanged(object sender, System.EventArgs e)
    {
        //level changed, update text
        SetEnemiesKilledBarSize(stageSystem.GetEnemiesKilledNormalized());
    }

}
