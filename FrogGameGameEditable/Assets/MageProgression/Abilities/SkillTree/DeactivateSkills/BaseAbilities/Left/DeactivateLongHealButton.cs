using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateLongHealButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject LongHealAbility;

    void Update()
    {
        if (SkillTreeCanvas == true)
        {
            LongHealAbility.gameObject.SetActive(false);
        }
    }
}