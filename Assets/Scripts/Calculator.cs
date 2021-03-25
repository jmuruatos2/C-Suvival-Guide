using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    // Start is called before the first frame update
    public float bill = 40;
    public float tip = .20f;
    public float total;

    void Start()
    {
        Debug.Log("Calculando");
        total = bill + (tip * bill);
        Debug.Log("Your bill is " + bill + " the tip is " + tip*bill + " so the total is " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
