using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateHealButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject healAbility;

    void Update()
    {
        if (SkillTreeCanvas == true)
        {
            healAbility.gameObject.SetActive(false);
        }
    }
}