using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public PlayerSO PSO;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotateTowardPlayer();
        ScrollZoom();
    }

    private void RotateTowardPlayer()
    {
        Camera.main.transform.rotation = Quaternion.LookRotation(PSO.position - Camera.main.transform.position);
    }

    private void ScrollZoom()
    {
        float fov = Camera.main.fieldOfView;
        fov += Input.mouseScrollDelta.y;
        fov = Mathf.Clamp(fov, 20, 60);
        Camera.main.fieldOfView = fov;
    }
}
