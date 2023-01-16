using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;


[CreateAssetMenu]
public class FireWallAbility : BaseAbilityClass
{
    public override void Activate(GameObject parent)
    {
        ThirdPersonShooterController thirdPersonShooterController = parent.GetComponent<ThirdPersonShooterController>();

        StarterAssetsInputs starterAssetsInputs = parent.GetComponent<StarterAssetsInputs>();

        //AbilityList abilityList = parent.GetComponent<AbilityList>();

        Vector3 mouseWorldPosition = Vector3.zero;

        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, thirdPersonShooterController.aimColliderLayerMask))
        {
            thirdPersonShooterController.debugTransform.position = raycastHit.point;
            mouseWorldPosition = raycastHit.point;
        }

        Vector3 aimDir = (mouseWorldPosition - thirdPersonShooterController.spawnBulletPosition.position).normalized;

        AbilityList abilityList = parent.GetComponent<AbilityList>();

        //Instantiate(abilityList.pfFireWall, abilityList.SpawnInFrontOfCharacterAbility.position, abilityList.SpawnInFrontOfCharaccterAbility.rotation);

        //Instantiate(abilityList.pfFireWall, raycastHit.point, abilityList.SpawnFireBlastPos.rotation);

        Instantiate(abilityList.pfFireWall, raycastHit.point, Quaternion.LookRotation(aimDir, Vector3.up));

    }
}
