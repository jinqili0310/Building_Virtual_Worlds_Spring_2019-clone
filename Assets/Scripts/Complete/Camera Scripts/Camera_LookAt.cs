using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_LookAt : MonoBehaviour
{
    // This complete script can be attached to a camera to make it
    // continuously point at another object.

    // The target variable shows up as a property in the inspector.
    // Drag another object onto it to make the camera look at it.

    public Transform target;

    // Update is called once per frame
    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);
    }
}
