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



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMaxHealth( int maxHealth)
    {
        maxHealth = _health.MaxHp;
        _slider.maxValue = maxHealth;
        _hpIndicator.SetText($"{maxHealth}/{maxHealth}");
    }
    public void SetHealth(int newValue)
    {
        newValue = (int)_slider.value - _health.Hp;

        _hpIndicator.SetText($"{newValue}/{_health.Hp}");

    }
}
