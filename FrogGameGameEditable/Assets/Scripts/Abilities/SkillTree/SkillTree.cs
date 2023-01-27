using UnityEngine;
using UnityEngine.Events;

public class SkillTree : MonoBehaviour
{

    public UnityEvent buttonClick;

    void Awake()
    {
        if (buttonClick == null) { buttonClick = new UnityEvent(); }
    }

    void OnMouseUp()
    {
       print("Click");
        buttonClick.Invoke();
    }
}
