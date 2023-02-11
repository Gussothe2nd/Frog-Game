using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
//using System.Diagnostics;

public class LevelWindow : MonoBehaviour
{

    [SerializeField] private Text levelText;
    //private Image experienceBarImage;
    [SerializeField] private Slider experienceBarFill;
    private LevelSystem levelSystem;

    public KeyCode key;
    //float multiplier 10f;

    private void Awake()
    {
        levelText = transform.Find("levelDisplayText").GetComponent<Text>();
        
        //experienceBarFill = transform.Find("ExperienceBar").Find("Fill").GetComponent<Image>();
        experienceBarFill = transform.Find("ExperienceBar").GetComponent<Slider>();


    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            levelSystem.AddExperience(25);
        }
    }


    private void SetExperienceBarSize(float experienceNormalized)
    {
        //experienceBarFill.fillAmount = experienceNormalized;
        experienceBarFill.value = experienceNormalized * 100f;
    }

    private void SetLevelNumber(int levelNumber)
    {
        levelText.text = "LEVEL\n" + (levelNumber + 1);
    }


    public void SetLevelSystem(LevelSystem levelSystem)
    {
        //set the LevelSystem object
        this.levelSystem = levelSystem;

        //Update the starting values
        SetLevelNumber(levelSystem.GetLevelNumber());
        SetExperienceBarSize(levelSystem.GetExperienceNormalized());

        //subscribe to the changed events
        levelSystem.OnExperienceChanged += LevelSystem_OnExperienceChanged;
        levelSystem.OnLevelChanged += LevelSystem_OnLevelChanged;
    }

    private void LevelSystem_OnLevelChanged(object sender, System.EventArgs e)
    {
        //level changed, update text
        SetLevelNumber(levelSystem.GetLevelNumber());
    }

    private void LevelSystem_OnExperienceChanged(object sender, System.EventArgs e)
    {
        //level changed, update text
        SetExperienceBarSize(levelSystem.GetExperienceNormalized());
    }

    public void Fart()
    {
        Debug.Log("fart");
    }

}
