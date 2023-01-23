using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityVisual : MonoBehaviour
{
    public Slider slider;

        public void SetMaxCoolDownVisual(float cooldownTime)
        {
            slider.maxValue = cooldownTime;
            slider.value = cooldownTime;
        }


        public void ShowCoolDownTime(float cooldownTime)
        {
            slider.value = cooldownTime;
        }
    }
