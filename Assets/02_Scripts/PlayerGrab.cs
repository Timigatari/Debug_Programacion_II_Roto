using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    #region REFERENCES
    UIManager uiManager;
    AudioManager audioManager;
    #endregion

    #region VARIABLES
    [Header("RAYCAST")]
    [Space(5)]
    float raycastDistance;
    LayerMask grabbableMask;
    #endregion

    [Header("GRAB SYSTEM")]
    [Space(5)]
    Transform playerHandsParent;
    Transform currentGrabbedObject;


    void Start()
    {

    }

    void Update()
    {

    }

    void RaycastHandler()
    {
        Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit, raycastDistance, grabbableMask);
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * raycastDistance, Color.cyan);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(currentGrabbedObject == null && hit.transform != null)
            {
                GrabObject(hit.transform);
            }

        }

        if (hit.transform != null)
        {
            uiManager.SetItemData(hit.transform.GetComponent<ItemData>());
        }
    }

    void GrabObject(Transform objectToGrab)
    {
        currentGrabbedObject = objectToGrab;

        objectToGrab.SetParent(playerHandsParent);
        objectToGrab.localPosition = Vector3.zero;
        objectToGrab.GetComponent<Rigidbody>().isKinematic = true;
    }

    void ReleaseObject()
    {
        if (currentGrabbedObject)
        {

        }
    }
}
