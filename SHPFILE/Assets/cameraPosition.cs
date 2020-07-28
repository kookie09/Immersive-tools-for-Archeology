using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPosition : MonoBehaviour
{
   private Camera cam;

    void Start()
    {
            cam = Camera.main;    
            cam.rect = new Rect(575584f, 575584f, 7.127485f,20f);
    }
}


