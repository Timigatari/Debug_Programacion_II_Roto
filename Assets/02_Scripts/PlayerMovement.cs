using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region VARIABLES
    [Header("CAMERA")]
    [Space(5)]
    public float mouseSensitivity;

    [Header("MOVEMENT")]
    [Space(5)]
    float movementSpeed;
    #endregion

    void Update()
    {

    }

    void CameraHandler()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        transform.Rotate(0, mouseX, 0);
        Camera.main.transform.Rotate(-mouseY, 0, 0);
    }

    void MovementHandler()
    {
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);
    }
}
