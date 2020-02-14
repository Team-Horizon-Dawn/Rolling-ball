using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ColourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeMaterial(GetComponent<Renderer>());
    }
    
    void ChangeMaterial(Renderer pickUpRenderer)
    {
        Color color = Color.red;
        float colourRandom = Random.Range(1, 4);
        print(colourRandom);
        switch(colourRandom)
        {
            case 1:
                color = Color.red;
                break;
            case 2:
                color = Color.green;
                break;
            case 3:
                color = Color.blue;
                break;
        }
        pickUpRenderer.material.color = color;
    }
}
