using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class CharacterManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> classes = new List<Sprite>();
    private int selectedClass = 0;
    public GameObject playerClass;

    public void NextOption()
    {
        selectedClass = selectedClass + 1;
        if (selectedClass == classes.Count)
        {
            selectedClass = 0;
        }

        sr.sprite = classes[selectedClass];
    }

    public void BackOption()
    {
        selectedClass = selectedClass - 1;
        if (selectedClass < 0)
        {
            selectedClass = classes.Count - 1;
        }

        sr.sprite = classes[selectedClass];
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerClass, "Assets/CharacterClasses.prefab");
        SceneManager.LoadScene("FirstStage");
    }
}

