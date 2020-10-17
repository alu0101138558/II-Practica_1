using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discoBall : MonoBehaviour
{
    int identifier = 4;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Identificador de discoBall: " + identifier + " Contador de discoBall: " + counter);
        counter++;
    }
}
