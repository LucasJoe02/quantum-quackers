using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatesMechanics : MonoBehaviour
{
    public GameObject duck1, duck2;
    private PlayerCharge charge1;
    private PlayerCharge charge2;
    public int gateCharge;
    public BoxCollider2D gate;

    // Start is called before the first frame update
    private void Start()
    {
        charge1 = duck1.GetComponent<PlayerCharge>();
        charge2 = duck2.GetComponent<PlayerCharge>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("duck1 = " + charge1.chargeLevel);
        //Debug.Log("duck2 = " + charge2.chargeLevel);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Duck1")
        {
            if (charge1.chargeLevel >= gateCharge)
            {
                gate.enabled = false;
            }
            else
            {
                gate.enabled = true;
            }
        }
        else if (collision.gameObject.tag == "Duck2")
        {
            if (charge2.chargeLevel >= gateCharge)
            {
                gate.enabled = false;
            }
            else
            {
                gate.enabled = true;
            }
        }
    }
}