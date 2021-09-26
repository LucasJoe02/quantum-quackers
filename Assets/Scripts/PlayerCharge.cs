using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharge : MonoBehaviour
{
    [Range(0, 3)]
    public int chargeLevel;
    private Material material;
    [Range(-10, 10)]
    public float intensity;

    private void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeGlow(chargeLevel);
    }

    public void ChangeGlow(int chargeLevel)
    {
        float border;
        Color glowColor;

        float factor = Mathf.Pow(2, intensity);
        Color magenta = new Color(191 * factor, 0 * factor, 97 * factor);
        Color lime = new Color(40 * factor, 191 * factor, 0 * factor);
        Color teal = new Color(0 * factor, 44 * factor, 191 * factor);

        if (chargeLevel == 1)
        {
            glowColor = magenta;
            border = 0.0066f;
        }
        else if (chargeLevel == 2)
        {
            glowColor = lime;
            border = 0.0099f;
        }
        else if (chargeLevel == 3)
        {
            glowColor = teal;
            border = 0.0142f;
        }
        else
        {
            glowColor = magenta;
            border = 0f;
        }
        material.SetFloat("_Thickness", border);
        material.SetColor("_Color", glowColor);
    }
}
