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
    private RectTransform _barRect;

    [SerializeField]
    private RectMask2D _mask;

    [SerializeField]
    private TMP_Text _hpIndicator;

    private float _maxRightMask;
    private float _initialRightMask;



    // Start is called before the first frame update
    void Start()
    {
        //x = left, w = top, y = bottom, z = right
        _maxRightMask = _barRect.rect.width - _mask.padding.x - _mask.padding.z;
        _hpIndicator.SetText($"{_health.Hp}/{_health.MaxHp}");
        _initialRightMask = _mask.padding.z;

    }


    public void SetValue(int newValue)
    {
        var targetWidth = newValue * _maxRightMask / _health.MaxHp;
        var newRightMask = _maxRightMask + _initialRightMask - targetWidth;
        var padding = _mask.padding;
        padding.z = newRightMask;
        _mask.padding = padding;
        _hpIndicator.SetText($"{newValue}/{_health.MaxHp}");
    }

}
