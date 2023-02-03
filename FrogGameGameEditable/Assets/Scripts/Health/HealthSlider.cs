using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HealthSlider : MonoBehaviour
{

    [SerializeField]
    private Health _health;

    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private TMP_Text _hpIndicator;

  


    public void SetMaxHealth( int health)
    {
        _slider.maxValue = health;
        _slider.value = health;
       
        
        _hpIndicator.SetText("Max");
    }
    public void SetHealth(int health)
    {
        _slider.value = health;
        //newValue = _health.Hp;

           //(int)_slider.value = _health.Hp;
        
        _hpIndicator.SetText($"{health}/{_health.MaxHp}");

    }

   
}
