using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateWallShieldButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject wallShieldAbility;

    void Update()
    {
        if(SkillTreeCanvas == true)
        {
            wallShieldAbility.gameObject.SetActive(false);
        }
    }
}
