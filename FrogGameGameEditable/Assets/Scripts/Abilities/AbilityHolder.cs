using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    public BaseAbilityClass ability;
    public AbilityVisual CoolDownVisual;
    public float cooldownTime;
    float activeTime;

    void Start()
    {
        CoolDownVisual.SetMaxCoolDownVisual(ability.cooldownTime);
        UpdateAbilityVisual(cooldownTime);

    }

    enum AbilityState
    {
        ready,
        active,
        cooldown
    }
    AbilityState state = AbilityState.ready;

    public KeyCode key;

    void Update()
    {


        //float percentageComplete = Time.deltaTime / abcooldownTime;

        switch (state)
        {
            case AbilityState.ready:
                if (Input.GetKeyDown(key))
                {
                    ability.Activate(gameObject);
                    state = AbilityState.active;
                    activeTime = ability.activeTime;
                    //UpdateAbilityVisual(cooldownTime);
                }
            break;
            case AbilityState.active:
                if (activeTime > 0)
                {
                    activeTime -= Time.deltaTime;
                }
                else
                {
                    state = AbilityState.cooldown;
                    cooldownTime = ability.cooldownTime;
                }
            break;
            case AbilityState.cooldown:
                if (cooldownTime > 0) {
                    cooldownTime -= Time.deltaTime;
                    UpdateAbilityVisual(cooldownTime -= Time.deltaTime);
                }
                else
                {
                    state = AbilityState.ready;
                }
            break;

        }

    }

    public void UpdateAbilityVisual(float cooldownTime)
    {
        CoolDownVisual.ShowCoolDownTime(cooldownTime);
    }
}