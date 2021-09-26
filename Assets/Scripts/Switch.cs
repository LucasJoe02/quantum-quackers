using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject duck_1, duck_2, test, sprite;
    public CharacterController2D move;
    public int count;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Switching();
    }

    public void Switching()
    {
        // Position Switch of the ducks

        if (Input.GetKeyDown("space"))
        {
            sprite.SetActive(true);
            test.transform.position = duck_1.transform.position;
            duck_1.transform.position = duck_2.transform.position;
            duck_2.transform.position = test.transform.position;
            StartCoroutine(Example());
        }
    }

    private IEnumerator Example()
    {
        yield return new WaitForSeconds(0.1f);
        sprite.SetActive(false);
    }
}