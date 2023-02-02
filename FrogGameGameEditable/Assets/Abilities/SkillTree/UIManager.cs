using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject hudCanvas = null;
    [SerializeField] private GameObject endCanvas = null;

    private void Start()
    {
        SetActiveHud(true);
    }

    public void SetActiveHud(bool state)
    {
            hudCanvas.SetActive(state);
            endCanvas.SetActive(!state);
    }

    public KeyCode key;

    public void update()
    {
        if (Input.GetKeyDown(key))
        {
        SetActiveHud(false);
        }
    }
    
}
