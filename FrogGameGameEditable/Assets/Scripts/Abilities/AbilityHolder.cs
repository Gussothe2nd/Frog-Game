using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    public BaseAbilityClass ability;
    public AbilityVisual CoolDownVisual;
    float cooldownTime;
    float activeTime;

    //private void Awake()
    //{
        //ThirdPersonShooterController = GetComponent<ThirdPersonShooterController>();
    //}

    //private ThirdPersonShooterController ThirdPersonShooterController;

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

    public void Update()
    {

        switch (state)
        {
            case AbilityState.ready:
                if (Input.GetKeyDown(key))
                {
                    ability.Activate(gameObject);
                    state = AbilityState.active;
                    activeTime = ability.activeTime;
                    //UpdateAbilityVisual(cooldownTime);
                    //FireAbility(true);

                }
            break;
                //case AbilityState.ready
                    //if (MultipleShots(true))
                //{

                //}
            case AbilityState.active:
                if (activeTime > 0)
                {
                    ability.ActivateMultiple(gameObject);
                    activeTime -= Time.deltaTime;
                }
                else
                {
                    //ability.BeginCooldown(gameObject);
                    state = AbilityState.cooldown;
                    cooldownTime = ability.cooldownTime;
                }
            break;
            case AbilityState.cooldown:
                if (cooldownTime > 0) {
                    cooldownTime -= Time.deltaTime;
                    UpdateAbilityVisual(cooldownTime -= Time.deltaTime);
                    ability.DestroyObject(gameObject);
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



    //public void FireAbility(bool activeTime)
    //{
        //ability.EnableLaser(true);
    //}

    //public void UpdateLaserPosition()
    //{
    //}


}