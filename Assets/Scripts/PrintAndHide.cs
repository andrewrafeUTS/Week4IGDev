using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private readonly int COUNTER_START_VALUE = 3;
    private readonly int RED_DISABLE_VALUE = 100;
    private readonly int BLUE_DISABLE_MIN_VALUE = 200;
    private readonly int BLUE_DISABLE_MAX_VALUE = 250;

    public Renderer rend;
    private int i;
    private int randomInt;
    // Start is called before the first frame update
    void Start()
    {
        i = COUNTER_START_VALUE;
        randomInt = Random.Range(BLUE_DISABLE_MIN_VALUE, BLUE_DISABLE_MAX_VALUE + 1);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(this.name + ":" + i);

        // Deactivate gameobject for red when i is 100
        if (gameObject.CompareTag("Red") && i == RED_DISABLE_VALUE)
        {
            gameObject.SetActive(false);
        }
        // Deactivate blue when i is equal to the randomInt variable
        else if (gameObject.CompareTag("Blue") && i == randomInt)
        {
            rend.enabled = false;
        }
    }
}
