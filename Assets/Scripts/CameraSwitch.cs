using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject duck1, duck2;
    public GameObject cam1, cam2, cam3, cam4;

    private bool maybe = false;

    public PlayerCharge charge1, charge2;

    // Start is called before the first frame update

    private void Start()
    {
        charge1 = duck1.GetComponent<PlayerCharge>();

        charge2 = duck2.GetComponent<PlayerCharge>();
        charge2 = duck2.GetComponent<PlayerCharge>();
    }

    // Update is called once per frame
    private void Update()
    {
        Camera();
    }

    public void Camera()
    {
        if ((charge1.chargeLevel > 0 || charge2.chargeLevel > 0) && Input.GetKeyDown("space"))
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