using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;
using UnityEngine.InputSystem;
using System.Collections.Specialized;

public class ThirdPersonShooterController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera aimVirtualCamera;
    [SerializeField] private float normalSensitivity;
    [SerializeField] private float aimSensitivity;
    [SerializeField] public LayerMask aimColliderLayerMask = new LayerMask();
    [SerializeField] public LayerMask ShortRaycastColliderLayerMask = new LayerMask();
    [SerializeField] public Transform debugTransform;
    [SerializeField] public Transform debugShortTransform;
    [SerializeField] private Transform pfBulletProjectile;
    [SerializeField] public Transform spawnBulletPosition;

    //float for short debugtransform distance


    // attempt to make skillTreeOverlay
    [SerializeField] private GameObject SkillTreeCanvas;
    private PlayerInput playerInput;


    private ThirdPersonController thirdPersonController;
    private StarterAssetsInputs starterAssetsInputs;
    public KeyCode key;

    private void Awake()
    {
        thirdPersonController = GetComponent<ThirdPersonController>();
        starterAssetsInputs = GetComponent<StarterAssetsInputs>();
        playerInput = GetComponent<PlayerInput>();
    }

    public void Update () {
        Vector3 mouseWorldPosition = Vector3.zero;

        Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 999f, aimColliderLayerMask))
        {
            debugTransform.position = raycastHit.point;;
            mouseWorldPosition = raycastHit.point;
        }
        if (Physics.Raycast(ray, out RaycastHit shortRaycastHit, 999f, ShortRaycastColliderLayerMask))
        {
            debugShortTransform.position = shortRaycastHit.point;
            //mouseWorldPosition = shortRaycastHit.point;
        }

        if (starterAssetsInputs.aim) {
            aimVirtualCamera.gameObject.SetActive(true);
            thirdPersonController.SetSensitivity(aimSensitivity);
            thirdPersonController.SetRotateOnMove(false);

            //change this to be only when clicking
            Vector3 worldAimTarget = mouseWorldPosition;
            worldAimTarget.y = transform.position.y;
            Vector3 aimDirection = (worldAimTarget - transform.position).normalized;

            transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 20f);
        } else {
            aimVirtualCamera.gameObject.SetActive(false);
            thirdPersonController.SetSensitivity(normalSensitivity);
            thirdPersonController.SetRotateOnMove(true);
        }
        //float distance = Vector3.Distance(spawnBulletPosition.position, raycastHit.point);

        if (starterAssetsInputs.shoot)
        {
            Vector3 aimDir = (mouseWorldPosition - spawnBulletPosition.position).normalized;
            Instantiate(pfBulletProjectile, spawnBulletPosition.position, Quaternion.LookRotation(aimDir, Vector3.up));
            starterAssetsInputs.shoot = false;

            //this is what turns the cam towards shot and its very messy and repetitive 
                //aimVirtualCamera.gameObject.SetActive(true);
               //thirdPersonController.SetSensitivity(aimSensitivity);
               //thirdPersonController.SetRotateOnMove(false);

               Vector3 worldAimTarget = mouseWorldPosition;
                worldAimTarget.y = transform.position.y;
                Vector3 aimDirection = (worldAimTarget - transform.position).normalized;

                transform.forward = Vector3.Lerp(transform.forward, aimDirection, Time.deltaTime * 1000f);
        } else
         {
                //aimVirtualCamera.gameObject.SetActive(false);
                //thirdPersonController.SetSensitivity(normalSensitivity);
                //thirdPersonController.SetRotateOnMove(true);
         }

        // skillTreeOverlay
        if (starterAssetsInputs.openSkillTree)
        {
            SkillTreeCanvas.gameObject.SetActive(true);
            starterAssetsInputs.cursorLocked = false;
            starterAssetsInputs.cursorInputForLook = false;
            playerInput.enabled = false;
        }

        if (Input.GetKeyDown(key))
        {
            playerInput.enabled = true;
            SkillTreeCanvas.gameObject.SetActive(false);
            starterAssetsInputs.openSkillTree = false;
            starterAssetsInputs.cursorLocked = true;
            starterAssetsInputs.cursorInputForLook = true;
        }
    }

}