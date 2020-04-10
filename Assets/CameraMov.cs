using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{

    void Start()
    {

    }

    void LateUpdate()
    {
        Camera.main.fieldOfView = (Camera.main.fieldOfView + 0.5f);
    }
}
