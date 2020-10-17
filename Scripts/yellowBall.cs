using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowBall : MonoBehaviour
{
    // Start is called before the first frame update
    int identifier = 3;
    int counter = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Identificador de yellowBall: " + identifier + " Contador de yellowBall: " + counter);
        counter++;
    }
}
