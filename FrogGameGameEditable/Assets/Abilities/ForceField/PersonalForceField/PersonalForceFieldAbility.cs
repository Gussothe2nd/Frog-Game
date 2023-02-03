using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using System.Collections.Specialized;
using System.Security.Cryptography;

//WARNING i couldn't figure out how to refernce the mousewordpoint that was allready produced by thirdpersonshootercontroller so i recalculated it here. maybe we can fix this later
[CreateAssetMenu]
public class PersonalForceFieldAbility : BaseAbilityClass
{
    private GameObject spawnedPersonalForceField;

    public override void Activate(GameObject parent)
    {

        ThirdPersonShooterController thirdPersonShooterController = parent.GetComponent<ThirdPersonShooterController>();

        StarterAssetsInputs starterAssetsInputs = parent.GetComponent<StarterAssetsInputs>();

        AbilityList abilityList = parent.GetComponent<AbilityList>();

        Vector3 mouseWorldPosition = Vector3.zero;

        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, thirdPersonShooterController.ShortRaycastColliderLayerMask))
        {
        thirdPersonShooterController.debugShortTransform.position = raycastHit.point;
        mouseWorldPosition = raycastHit.point;
        }

        Vector3 aimDir = (mouseWorldPosition - thirdPersonShooterController.spawnBulletPosition.position).normalized;

            spawnedPersonalForceField = Instantiate(abilityList.pfPersonalForceField, raycastHit.point, Quaternion.LookRotation(aimDir, Vector3.up)) as GameObject;
    }

    public override void ActivateMultiple(GameObject parent)
    {
        ThirdPersonShooterController thirdPersonShooterController = parent.GetComponent<ThirdPersonShooterController>();

        StarterAssetsInputs starterAssetsInputs = parent.GetComponent<StarterAssetsInputs>();

        AbilityList abilityList = parent.GetComponent<AbilityList>();

        Vector3 mouseWorldPosition = Vector3.zero;

        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, thirdPersonShooterController.ShortRaycastColliderLayerMask))
        {
        thirdPersonShooterController.debugShortTransform.position = raycastHit.point;
        mouseWorldPosition = raycastHit.point;
        }

        Vector3 aimDir = (mouseWorldPosition - thirdPersonShooterController.spawnBulletPosition.position).normalized;

        //float distance = Vector3.Distance(thirdPersonShooterController.spawnBulletPosition.position, raycastHit.point);

        //Vector3 middlePoint = thirdPersonShooterController.spawnBulletPosition.position + raycastHit.point / 2f;



    if (raycastHit.point != null)
    {
            //spawnedPersonalForceField = Instantiate(abilityList.pfPersonalForceField, raycastHit.point, Quaternion.LookRotation(aimDir, Vector3.up)) as GameObject;

            spawnedPersonalForceField.transform.position = raycastHit.point;

            spawnedPersonalForceField.transform.rotation = Quaternion.LookRotation(aimDir, Vector3.up);




            //spawnedPersonalForceField.transform.Translate(Vector3.forward * distance / 2f);

        }
    }

    public override void DestroyObject(GameObject parent)
    {
        Destroy(spawnedPersonalForceField);
    }
}    