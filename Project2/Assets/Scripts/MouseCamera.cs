using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour

{
    [SerializeField] private float mouseSensitivy = 0.5f;
    private Camera _mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraLook();
    }
    private void CameraLook()
    {
        var xPos = Input.GetAxis("Mouse X");
        var yPos = Input.GetAxis("Mouse Y");

        var rotationLR = transform.localEulerAngles;
        rotationLR.y += xPos * mouseSensitivy;
        transform.rotation = Quaternion.AngleAxis(rotationLR.y, Vector3.up);

        var cameraRot = _mainCamera.gameObject.transform.localEulerAngles;
        cameraRot.x += yPos * mouseSensitivy;
        _mainCamera.gameObject.transform.localRotation = Quaternion.AngleAxis(cameraRot.x, Vector3.right);

    }
}
