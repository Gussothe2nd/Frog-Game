using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MakeTransparent : MonoBehaviour
{
    [SerializeField] private Image backgroundImage;
    private Color backgroundColor;

    // Start is called before the first frame update
    void Start()
    {
        backgroundColor.a = 0.9f;
        backgroundImage.color = backgroundColor;
    }

}
