using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string nombre = "Javier";
    public int age = 34;
    public float speed = 5.4f;
    public uint health = 10000;
    public uint score = 100000;
    public bool allKeys = false;
    public ushort ammo = 50;


    // Start is called before the first frame update
    void Start()
    {
        MostrarStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MostrarStats()
    {
        Debug.Log(
       "\n Stats" +
       "\n Nombre: " + nombre +
       "\n Edad: " + age +
       "\n Velocidad: " + speed +
       "\n Salud: " + health +
       "\n Puntuación: " + score +
       "\n Todas las llaves: " + allKeys +
       "\n Ammo: " + ammo
       );
    }
}
