using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatesMechanics : MonoBehaviour
{
    public PlayerCharge charge;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" /*&& charge.chargeLevel == 1*/)
        {
            charge.gate1.enabled = false;
            Debug.Log(collision.name);
        }
        else
        {
            charge.gate1.enabled = true;
        }
    }
}