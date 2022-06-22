using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Vector3 CameraMove;

    Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }
    void Update()
    {
        if (transform.position.y < 2.5f)
        {
            CameraMove = new Vector3(0.64f, 2f, -1.35351f);
        }
        else if(transform.position.y > 4f)
        {
            
            CameraMove = new Vector3(0.64f, 4.9f, -1.35351f);
        }
        else if (transform.position.y > 6f)
        {
            CameraMove = new Vector3(0.64f, 6.5f, -1.35351f);
        }
        else if (transform.position.y > 8f)
        {
            CameraMove = new Vector3(0.64f, 9f, -1.35351f);
        }

        mainCam.transform.position = CameraMove;
        
    }

}