using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        Debug.Log(this.name + ":" + counter);
    }
}
