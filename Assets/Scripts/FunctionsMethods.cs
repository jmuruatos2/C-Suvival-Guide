using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsMethods : MonoBehaviour
{
    [SerializeField]
    private int health = 10;

    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vectorArray = GenerarFiveVector3();
        foreach (var v in vectorArray)
        {
            Debug.Log("Valores vector x:" + v.x + " y:" + v.y + " z:" + v.z);
        }


    }

    // Update is called once per frame
    void Update()
    {


 

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    DamagePlayer();
            
        //}
    }

    private Vector3[] GenerarFiveVector3()
    {
        Vector3[] vector3Array = new Vector3[5];

        for(int i=0;i < 5; i++)
        {
            vector3Array[i] = GeneraVector3();
        }

        return vector3Array;
    }

private Vector3 GeneraVector3()
    {
        return new Vector3(RandomGen(),RandomGen(),RandomGen());
    }

    private int RandomGen()
    {
        return Random.Range(-4, 4);
    }
    public void DamagePlayer()
    {
        if (IsAlive())
        {
            health -= Random.Range(1, 4);
            if (health < 1)
            {
                health = 0;
                Debug.Log("Player dead");
            }
        }
       
    }
    public bool IsAlive()
    {
        if (health > 0)
        {
            return true;
        }
        return false;
    }


    private void ChangeCubeColor(GameObject objeto, Color color)
    {
        objeto.GetComponent<Renderer>().material.SetColor("_Color", color);
    }
}
