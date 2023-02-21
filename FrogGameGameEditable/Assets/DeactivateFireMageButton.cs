using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateFireMageButton : MonoBehaviour
{
    public GameObject SkillTreeCanvas;

    public GameObject fireMageAbility;

    void Start()
    {
        //if (SkillTreeCanvas == true)
        //{
        // fireMageAbility.gameObject.SetActive(false);
        //}

        fireMageAbility.gameObject.SetActive(false);
    }
}