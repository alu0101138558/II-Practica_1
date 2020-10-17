using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangeTerrain : MonoBehaviour
{
    int identifier = 5;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Identificador de orangeTerrain: " + identifier + " Contador de orangeTerrain: " + counter);
        counter++;
    }
}
