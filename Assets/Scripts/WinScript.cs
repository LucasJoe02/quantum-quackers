using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public GameObject bread_1, bread_2, winPanel;

    // Update is called once per frame
    private void Update()
    {
        HasWon();
    }

    // adjusted so that both bread need to be taken
    private void HasWon()
    {
        if (bread_1 == null && bread_2 == null)
        {
            winPanel.SetActive(true);
        }
    }
}