using System.Diagnostics;
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
        
        if (transform.position.y > 0f &&  transform.position.y < 4f)
        {
            // UnityEngine.Debug.Log("first" +  transform.position.y);

            CameraMove = new Vector3(1.64f, 1.5f, -1.35351f);
        }
        else if(transform.position.y > 4f && transform.position.y <= 6f)
        {
            // UnityEngine.Debug.Log("second" +  transform.position.y);
            
            CameraMove = new Vector3(0.64f, 6.2f, -1.35351f);
        }
        else if (transform.position.y > 8f && transform.position.y <= 11f)
        {
            if (transform.position.x >8.7f && transform.position.x <= 14f){
                CameraMove = new Vector3(8.67f, 9f, -1.35351f);
            }else{
                CameraMove = new Vector3(0.64f, 9f, -1.35351f);
            }         
        }
        mainCam.transform.position = CameraMove;
        
    }

}