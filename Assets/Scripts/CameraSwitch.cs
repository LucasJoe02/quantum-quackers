using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject cam1, cam2, cam3, cam4;
    private bool maybe = false;
    private PlayerCharge charge;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("space") /* && charge.chargeLevel >= 0*/)
        {
            cam1.SetActive(maybe);
            cam2.SetActive(maybe);
            cam3.SetActive(!maybe);
            cam4.SetActive(!maybe);

            if (maybe == true)
            {
                maybe = false;
            }
            else
            {
                maybe = true;
            }
        }
    }
}