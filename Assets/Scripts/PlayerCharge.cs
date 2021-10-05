using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCharge : MonoBehaviour
{
    public Collider2D gate1, gate2, gate3;
    public GameObject duck_1, duck_2, test, sprite, canvas;

    [Range(0, 3)]
    public int chargeLevel;

    public TextMeshProUGUI chargeTextUI;

    private Material material;

    [Range(-10, 10)]
    public float intensity;

    private void Start()
    {
        chargeTextUI.text = "0";
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    private void Update()
    {
        IsDead();
        ChangeGlow(chargeLevel);
        Switching();
        ChargeReduction();
        UpdateChargeText();
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
    /// Detects "grapes" tag when hitting a collider
    /// increases charge level when detected
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bread")
        {
            /// for win condition
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "grape")
        {
            chargeLevel++;
            Destroy(collision.gameObject);
        }

        /*if (chargeLevel == 1 && collision.gameObject.tag == "Gate")
        {
            gate1.enabled = false;
        }*/
        if (chargeLevel == 2 && collision.gameObject.tag == "Gate")
        {
            gate2.enabled = false;
        }
        if (chargeLevel == 3 && collision.gameObject.tag == "Gate")
        {
            gate3.enabled = false;
        }
        /// for fail condition
        if (collision.gameObject.tag == "Death")
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Reduce the charge everytime a switch occurs
    /// Sets the collider to active within the scene
    /// </summary>
    private void ChargeReduction()
    {
        if (Input.GetKeyDown("space") && chargeLevel == 1)
        {
            chargeLevel--;
            gate1.enabled = true;
        }
        if (Input.GetKeyDown("space") && chargeLevel == 2)
        {
            chargeLevel--;
            gate2.enabled = true;
        }
        if (Input.GetKeyDown("space") && chargeLevel == 3)
        {
            chargeLevel--;
            gate3.enabled = true;
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
    /// Updates the charge text of the ducks
    /// so the UI displays the correct charge level
    /// </summary>
    public void UpdateChargeText()
    {
        chargeTextUI.text = chargeLevel.ToString();
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

    /// <summary>
    /// Checking if a duc has died
    /// returns a fails condition screen
    /// </summary>
    private void IsDead()
    {
        if (duck_1 == null || duck_2 == null)
        {
            canvas.SetActive(true);
        }
    }
}