using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateDomeShieldButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject domeShieldAbility;

    void Update()
    {
        if (SkillTreeCanvas == true)
        {
            domeShieldAbility.gameObject.SetActive(false);
        }
    }
}