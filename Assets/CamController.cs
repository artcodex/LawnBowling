using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera alternateCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        alternateCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.enabled = !mainCamera.enabled;
            alternateCamera.enabled = !alternateCamera.enabled;
        }
    }
}
