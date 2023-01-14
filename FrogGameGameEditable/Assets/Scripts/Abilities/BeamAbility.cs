using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Cinemachine;
using StarterAssets;
//using UnityEngine.InputSystem;
//using System.Collections.Specialized;
//using static ThirdPersonShooterController;

//WARNING i couldn't figure out how to refernce the mousewordpoint that was allready produced by thirdpersonshootercontroller so i recalculated it here. maybe we can fix this later
[CreateAssetMenu]
public class BeamAbility : BaseAbilityClass
{
    //private Transform spawnedLaser;
    private GameObject spawnedLaser;
    //private GameObject spawnedLaserDamage;

    //void Awake()
    //{
       //spawnedLaser = Instantiate(abilityList.pfBeam, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));
    //}


    public override void Activate(GameObject parent)
    {

        ThirdPersonShooterController thirdPersonShooterController = parent.GetComponent<ThirdPersonShooterController>();

        StarterAssetsInputs starterAssetsInputs = parent.GetComponent<StarterAssetsInputs>();

        AbilityList abilityList = parent.GetComponent<AbilityList>();

        Vector3 mouseWorldPosition = Vector3.zero;

        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, thirdPersonShooterController.aimColliderLayerMask))
        {
        thirdPersonShooterController.debugTransform.position = raycastHit.point;
        mouseWorldPosition = raycastHit.point;
        }

        Vector3 aimDir = (mouseWorldPosition - thirdPersonShooterController.spawnBulletPosition.position).normalized;

            spawnedLaser = Instantiate(abilityList.pfBeam, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up)) as GameObject;
            //spawnedLaserDamage = Instantiate(abilityList.BeamDamage, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up)) as GameObject;


        //abilityList.EnableLaser();

        //if (thirdPersonShooterController.spawnBulletPosition != null)
        //{
        //Instantiate(abilityList.pfBeam, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up)).transform.position = thirdPersonShooterController.spawnBulletPosition.position;
        //}


        //Instantiate(abilityList.pfBeam, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));

        //spawnedLaser = Instantiate(abilityList.pfBeam.transform.gameObject, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up)) as GameObject;

        //spawnedLaser = Instantiate(abilityList.pfBeam, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up)) as GameObject;

        //Instantiate(spawnedLaser);

        //void Update()
        //{
        //Instantiate(spawnedLaser);
        //}

        //EnableLaser();

        //UpdateLaser();

        //void EnableLaser()
        //{
        //spawnedLaser.SetActive(true);
        //}


        //void UpdateLaser()
        //{

        //if(thirdPersonShooterController.spawnBulletPosition != null)
        //{
        //spawnedLaser.transform.position = thirdPersonShooterController.spawnBulletPosition.position;
        //}
        //}

        //void UpdateLaser()
        //{
        //spawnedLaser.transform.position = thirdPersonShooterController.spawnBulletPosition.position;

        //}

        //if (parent.cooldown)
        //{
        //EnableLaser();
        //}

        //if (parent.active)
        //{
        //UpdateLaser();
        //}

        //if (parent.cooldownTime > 0)
        //{
        //DisableLaser();
        //}


        //void EnableLaser()
        //{
        //Instantiate(abilityList.pfBeam, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));
        //}

        //void UpdateLaser()
        //{
        //if(thirdPersonShooterController.spawnBulletPosition != null) { 
        //Instantiate(abilityList.pfBeam, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up)).transform.position = thirdPersonShooterController.spawnBulletPosition.position;
        //}
        //}
    }
    public override void ActivateMultiple(GameObject parent)
    {
        ThirdPersonShooterController thirdPersonShooterController = parent.GetComponent<ThirdPersonShooterController>();

        StarterAssetsInputs starterAssetsInputs = parent.GetComponent<StarterAssetsInputs>();

        AbilityList abilityList = parent.GetComponent<AbilityList>();

        Vector3 mouseWorldPosition = Vector3.zero;

        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, thirdPersonShooterController.aimColliderLayerMask))
        {
            thirdPersonShooterController.debugTransform.position = raycastHit.point;
            mouseWorldPosition = raycastHit.point;
        }

        Vector3 aimDir = (mouseWorldPosition - thirdPersonShooterController.spawnBulletPosition.position).normalized;

        //spawnedLaser = Instantiate(abilityList.pfBeam, thirdPersonShooterController.spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up)) as GameObject;

        if(thirdPersonShooterController.spawnBulletPosition != null)
        {
            spawnedLaser.transform.position = thirdPersonShooterController.spawnBulletPosition.position;
            spawnedLaser.transform.rotation = Quaternion.LookRotation(aimDir, Vector3.up);
            spawnedLaser.transform.localScale = raycastHit.point;
        }

        //if(GameObject parent.AbilityState.cooldown){
           //DestroyObject(spawnedLaser);
        //}

        //GameObject spawnedLaser;


    }

    public override void DestroyObject(GameObject parent)
    {
        Destroy(spawnedLaser);
    }

    //public override void BeginCooldown(GameObject parent)
    //{

    //}
    //public override void BeginCooldown(GameObject parent)
    //{
    //void Update()
    //{
    //Instantiate(spawnedLaser);
    //}

}    