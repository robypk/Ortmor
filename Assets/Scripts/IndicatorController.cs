using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class IndicatorController : MonoBehaviour
{
    private ARRaycastManager arRaycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject placeholder;
    [SerializeField] GameObject CapureButton;
    [SerializeField] GameObject SearchingDialogue;

    bool isPlaced = false;

    void Start()
    {
        arRaycastManager = FindFirstObjectByType<ARRaycastManager>();
        CapureButton.SetActive(false);
        SearchingDialogue.SetActive(true);
    }

    void Update()
    {
        if (isPlaced)
        {
            return;
        }
        if (arRaycastManager.Raycast((new Vector2(Screen.width / 2, Screen.height / 2)), hits, TrackableType.Planes))
        {

            Vector3 hitPosition = hits[0].pose.position;
            Quaternion hitRot = hits[0].pose.rotation;
            transform.position = hitPosition;
            transform.rotation = hitRot;
            placeholder.SetActive(true);
            CapureButton.SetActive(true);
            SearchingDialogue.SetActive(false);
        }
        else
        {
            CapureButton.SetActive(false);
            SearchingDialogue.SetActive(true);
            placeholder.SetActive(false);
        }
    }


    public void onPLaceButtonClick()
    {
        isPlaced = true;
        CapureButton.SetActive(false);
        SearchingDialogue.SetActive(false);
    }
}