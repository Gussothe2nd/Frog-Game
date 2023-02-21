using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using StarterAssets;
using UnityEngine.InputSystem;
using Cinemachine;

public class DragWindow : MonoBehaviour, IDragHandler
{
    public GameObject player;

    public float scaleFactor;

    public GameObject cinemachineVirtualCamera;

    public GameObject skillTree;
    //private PlayerInput playerInput;
    //private StarterAssetsInputs starterAssetsInputs;


    //public float mouseScrollY;

    [SerializeField] private RectTransform dragRectTransform;
    [SerializeField] private Canvas canvas;


    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    private void Awake()
    {
        //cinemachineVirtualCamera = cinemachineVirtualCamera.GetComponent<CinemachineVirtualCamera>();

        //camera = player.GetComponent<Camera>();

        //could figure out how to do this through the unity input system
        //playerInput = player.GetComponent<PlayerInput>();

        //starterAssetsInputs = player.GetComponent<StarterAssetsInputs>();
    }

    void Update()
    {

        if(Input.GetAxis ("Mouse ScrollWheel") > 0)
        {
            //GetComponent<Transform>.position = new Vector3()
            //skillTree.transform.localScale = new Vector3(skillTree.transform.localScale.x, skillTree.transform.localScale.x, skillTree.transform.localScale.x);

            //dragRectTransform.GetComponent<RectTransform>(); //.Width--;

            //dragRectTransform.sizeDelta = new Vector2(900, 900);

            canvas.scaleFactor = scaleFactor++/10;

            //canvas.Scaler = 

            //cinemachineVirtualCamera.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView--;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //GetComponent<Transform>.position = new Vector3()
            //skillTree.transform.localScale = new Vector3(skillTree.transform.localScale.x, skillTree.transform.localScale.x, skillTree.transform.localScale.x);

            //dragRectTransform.GetComponent<RectTransform>(); //.Width--;

            //dragRectTransform.sizeDelta = new Vector2(900, 900);

            canvas.scaleFactor = scaleFactor--/10;

            //canvas.Scaler = 

            //cinemachineVirtualCamera.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView--;
        }

        //could figure out how to do this through the unity input system
        //if (starterAssetsInputs.zoomScrollWheel > 0)
        //{
        //print("Zoom Out");
        //}
    }

}
