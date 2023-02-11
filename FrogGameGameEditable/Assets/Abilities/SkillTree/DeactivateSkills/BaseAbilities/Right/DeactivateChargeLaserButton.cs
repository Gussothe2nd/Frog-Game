using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateChargeLaserButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject chargeLaserAbility;

    void Update()
    {
        if (SkillTreeCanvas == true)
        {
            chargeLaserAbility.gameObject.SetActive(false);
        }
    }
}