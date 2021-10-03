using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharge : MonoBehaviour
{
    public Collider2D tilemapCollider;
    public GameObject duck_1, duck_2, test, sprite;

    private CameraSwitch cams;

    public bool isActive = false;

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
    private void Update()
    {
        ChangeGlow(chargeLevel);
        Gates();
        Switching();
        ChargeReduction();
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

    /// <summary>
    /// sets the gates to false for phasing to occur
    /// </summary>
    public void Gates()
    {
        if (chargeLevel == 1)
        {
            tilemapCollider.enabled = false;
        }
    }

    /// <summary>
    /// Detects "grapes" tag when hitting a collider
    /// increases charge level when detected
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "grape")
        {
            chargeLevel++;
            Destroy(collision.gameObject);
        }
    }

    /// <summary>
    /// Reduce the charge everytime a switch occurs
    /// Sets the collider to active within the scene
    /// </summary>
    private void ChargeReduction()
    {
        if (Input.GetKeyDown("space") && chargeLevel >= 1)
        {
            chargeLevel--;
            tilemapCollider.enabled = true;
        }
    }

    /// <summary>
    /// Switch the position of the ducks
    /// when charge levels are greater than or equals to 1
    /// </summary>
    public void Switching()
    {
        // Position Switch of the ducks

        if (Input.GetKeyDown("space") && chargeLevel > 0)
        {
            sprite.SetActive(true);
            test.transform.position = duck_1.transform.position;
            duck_1.transform.position = duck_2.transform.position;
            duck_2.transform.position = test.transform.position;
            StartCoroutine(Example());
        }
    }

    /// <summary>
    /// to use for time calculation
    /// </summary>
    /// <returns></returns>
    private IEnumerator Example()
    {
        yield return new WaitForSeconds(0.1f);
        sprite.SetActive(false);
    }
}