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

    bool isPlaced = false;

    void Start()
    {
        arRaycastManager = FindFirstObjectByType<ARRaycastManager>();
    }

    void Update()
    {
        if (arRaycastManager.Raycast((new Vector2(Screen.width / 2, Screen.height / 2)), hits, TrackableType.Planes) && !isPlaced)
        {
            Vector3 hitPosition = hits[0].pose.position;
            Quaternion hitRot = hits[0].pose.rotation;
            transform.position = hitPosition;
            transform.rotation = hitRot;
            placeholder.SetActive(true);
        }
    }


    public void onPLaceButtonClick()
    {
        isPlaced = true;
    }
}