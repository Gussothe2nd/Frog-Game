using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePersonalShieldButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject personalShieldAbility;

    void Update()
    {
        if (SkillTreeCanvas == true)
        {
            personalShieldAbility.gameObject.SetActive(false);
        }
    }
}