using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAction : MonoBehaviour
{

    public GameObject UI;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    }

    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            Debug.Log("Hit object: " + hit.collider.gameObject.name);

            if (hit.collider.gameObject.name == "Sweden")
            {
                Debug.Log("You hit the Sweden Telescope");
                UI.SetActive(true);
            }
            else if (hit.collider.gameObject.name == "London")
            {
                UI.SetActive(true);
                Debug.Log("You hit the London Telescope");

            }
            else if (hit.collider.gameObject.name == "Florida")
            {
                UI.SetActive(true);
                Debug.Log("You hit the Florida Telescope");

            }
            else if (hit.collider.gameObject.name == "Barcelona")
            {
                UI.SetActive(true);
                Debug.Log("You hit the Barca Telescope");

            }
            else if (hit.collider.gameObject.name == "Rome")
            {
                UI.SetActive(true);
                Debug.Log("You hit the Rome Telescope");

            }
            else if (hit.collider.gameObject.name == "LA")
            {
                UI.SetActive(true);
                Debug.Log("You hit the LAq Telescope");

            }
            else if(hit.collider.gameObject.name == "Sphere128")
            {
                UI.SetActive(false);
            }
        }
    }
}
