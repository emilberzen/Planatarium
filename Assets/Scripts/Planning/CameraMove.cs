using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] private Camera cam;
    public GameObject Target;
    public GameObject Earth;

    public float speed = 1f;
    public float sensitivity = 1f;
    public float minFov = 5f;
    public float maxFov =50f;

    public float speedNear = 0.5f;
    public float speedFar = 5; 


    // Update is called once per frame
    void Update()
    {

  

        //Rotation
        if (Input.GetMouseButton(0))
        {


            Target.transform.position = new Vector3();
            Target.transform.Rotate(new Vector3(1, 0, 0), Input.GetAxis("Mouse Y") * -speed);
            Target.transform.Rotate(new Vector3(0, 1, 0), Input.GetAxis("Mouse X") * speed, Space.World);
            Target.transform.Translate(new Vector3(0, 0, -3));


        }
        else
        {
            //Rotates the sun slowly 
            //Earth.transform.Rotate(new Vector3(0, 0.001f, 0));
        }

        //ZOOM
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * -sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;

        if (fov < 20)
        {

            speed = speedNear;
        }
        else
        {
            speed = speedFar;
        }

    }


}

