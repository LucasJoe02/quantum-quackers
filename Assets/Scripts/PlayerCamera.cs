using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Vector3 offset = new Vector3();
    public GameObject Player;
    public Camera cam, cam2;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Player.transform.position + offset;
        if (Input.GetKeyDown("space"))
        {
            Player.
        }
    }
}