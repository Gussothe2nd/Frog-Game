using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateIntenseLaserButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject intenseLaserAbility;

    void Update()
    {
        if (SkillTreeCanvas == true)
        {
            intenseLaserAbility.gameObject.SetActive(false);
        }
    }
}
