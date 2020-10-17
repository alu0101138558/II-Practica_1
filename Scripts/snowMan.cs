using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowMan : MonoBehaviour
{
    int identifier = 1;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Los objetos que se han utilizado son: SnowMan, Ethan, yellowBall, discoBall, orangeTerrain.");
        Debug.Log("Identificador de SnowMan: " + identifier + " Contador de SnowMan: " + counter);
        counter++;
    }
}
