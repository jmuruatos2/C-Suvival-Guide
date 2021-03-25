using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float[] quiz;
    public float promedio;
    // Start is called before the first frame update
    void Start()
    {
        float total = 0;
        quiz = new float[5];
        for (int i=0; i<5;i++)
        {
            quiz[i] = Random.value * 100;
            Debug.Log("Calificacion del quiz" + i + " es " + quiz[i]);
            total += quiz[i];
        }
        promedio = total / 5;
        Debug.Log("Promedio sin truncar " + promedio);
        promedio = Mathf.Round(promedio * 100f) / 100f;

        Debug.Log("Promedio con round es: " + promedio);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
