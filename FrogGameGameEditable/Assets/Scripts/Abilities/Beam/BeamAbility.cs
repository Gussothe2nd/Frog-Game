using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using System.Collections.Specialized;
using System.Security.Cryptography;

//WARNING i couldn't figure out how to refernce the mousewordpoint that was allready produced by thirdpersonshootercontroller so i recalculated it here. maybe we can fix this later
[CreateAssetMenu]
public class BeamAbility : BaseAbilityClass
{
    //private Transform spawnedLaser;
    private GameObject spawnedLaser;

    private Vector3 scaleChange, positionChange;

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

        float distance = Vector3.Distance(thirdPersonShooterController.spawnBulletPosition.position, raycastHit.point);

        Vector3 middlePoint = thirdPersonShooterController.spawnBulletPosition.position + raycastHit.point / 2f;

        //Vector3 middlePoint2 = thirdPersonShooterController.spawnBulletPosition.position - raycastHit.point;


        if (thirdPersonShooterController.spawnBulletPosition != null)
        {
            spawnedLaser.transform.position = thirdPersonShooterController.spawnBulletPosition.position;

            //spawnedLaser.transform.position = middlePoint;


            spawnedLaser.transform.rotation = Quaternion.LookRotation(aimDir, Vector3.up);


            
            //spawnedLaser.transform.localScale = raycastHit.point;
            
            spawnedLaser.transform.localScale = new Vector3(spawnedLaser.transform.localScale.x, spawnedLaser.transform.localScale.x, distance);


            spawnedLaser.transform.Translate(Vector3.forward * distance / 2f);

        }


    }

    public override void DestroyObject(GameObject parent)
    {
        Destroy(spawnedLaser);
    }



  
}    