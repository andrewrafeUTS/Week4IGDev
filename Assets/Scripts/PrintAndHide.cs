using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{ 
    public Renderer rend;
    private int i;
    private int randomInt;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randomInt = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(this.name + ":" + i);

        // Deactivate gameobject for red when i is 100
        if (gameObject.CompareTag("Red") && i == 100)
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
