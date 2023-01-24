using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Diagnostics;

public class LevelWindow : MonoBehaviour
{

    [SerializeField] private Text levelText;
    //private Image experienceBarImage;
    [SerializeField] private Slider experienceBarFill;
    private LevelSystem levelSystem;

    public Button five;
    public Button fiftty;
    public Button fiveHundred;
    public KeyCode key;
    //float multiplier 10f;

    private void Awake()
    {
        levelText = transform.Find("levelDisplay").GetComponent<Text>();
        
        //experienceBarFill = transform.Find("ExperienceBar").Find("Fill").GetComponent<Image>();
        experienceBarFill = transform.Find("ExperienceBar").GetComponent<Slider>();

        //five = GetComponent<Button>();
        //five.onClick.AddExperience(50);

        //five.onClick.AddListener(btnClick);
        //transform.Find("50XP").GetComponent<Button_UI>.ClickFunc = () => levelSystem.AddExperience(50);
        //transform.Find("500XP").GetComponent<Button_UI>.ClickFunc = () => levelSystem.AddExperience(500);

        //SetExperienceBarSize(50f);
        //SetLevelNumber(7);


    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            levelSystem.AddExperience(25);
        }
    }

    //void btnClick()
    //{
    //UnityEngine.Debug.Log("button pressed");
    //}


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

}
