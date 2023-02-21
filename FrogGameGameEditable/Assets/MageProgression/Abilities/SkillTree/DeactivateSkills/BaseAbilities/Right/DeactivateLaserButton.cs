using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateLaserButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject laserAbility;

    void Update()
    {
        if (SkillTreeCanvas == true)
        {
            laserAbility.gameObject.SetActive(false);
        }
    }
}