using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] private Camera cam;

    private Vector3 previousPos;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            previousPos = cam.ScreenToViewportPoint(Input.mousePosition);

        }

        if (Input.GetMouseButton(0))
        {

            Vector3 direction = previousPos - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = new Vector3();
            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 10);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 10, Space.World);
            cam.transform.Translate(new Vector3(0, 0, -3));
        }


    }
}
