using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

    public void MoveCameraUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 3.0f, transform.position.z);
    }

    public void MoveCameraDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 3.0f, transform.position.z);
    }
}
