using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    //Define Variables
    public Vector2 sensitivities;
    private Vector2 xyRotation;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    //Move player with mouse movement
    void Update()
    {
        Vector2 MouseInput = new Vector2
        {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };

        xyRotation.y += MouseInput.x * sensitivities.x;

        xyRotation.x = Mathf.Clamp(xyRotation.x, -90f, 90f);

        transform.eulerAngles = new Vector3(0f, xyRotation.y, 0f);
    }
}
