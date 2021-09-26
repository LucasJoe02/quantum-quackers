using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera cam1;
    public float offset = 0.5f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            cam1.rect = new Rect(0, offset, 1, 0.5f);
        }
    }
}