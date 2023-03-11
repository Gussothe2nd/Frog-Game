using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralBar : MonoBehaviour
{
    [field:SerializeField]
    public int MaxValue { get; private set; }

    [field:SerializeField]
    public int Value { get; private set; }

    [SerializeField]
    private RectTransform _topBar;

    [SerializeField]
    private RectTransform _bottomBar;

    private float _fullWidth;
    private float TargetWidth => Value * _fullWidth / MaxValue;

    private void Start()
    {
        _fullWidth = _topBar.rect.width;
    }

    public void Change(int amount)
    {
        Value = Mathf.Clamp(Value + amount, 0, MaxValue);

    }


    private void Update()
    {
        //Healthdata
    }
}
