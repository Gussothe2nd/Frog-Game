using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateSuperHealButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject superHealAbility;

    void Update()
    {
        if (SkillTreeCanvas == true)
        {
            superHealAbility.gameObject.SetActive(false);
        }
    }
}