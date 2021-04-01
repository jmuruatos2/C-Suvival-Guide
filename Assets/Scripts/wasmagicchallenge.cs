using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasmagicchallenge : MonoBehaviour
{
    private bool _iEnabled;
    [SerializeField]
    private bool _cambiarColor;
    private Renderer _renderer;
    private WaitForSeconds _waitForSeconds;
    // Start is called before the first frame update
    void Start()
    {
        _iEnabled = true;
        _cambiarColor = true;
        _renderer = transform.GetComponentInParent<Renderer>();
        _waitForSeconds = new WaitForSeconds(3);
        
        StartCoroutine("ChangeColor");
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetKeyDown(KeyCode.I) && _iEnabled)
        //{
        //    StartCoroutine(HideCube());
        //}


    }

    //Ienumerator se activa con "i" , desaparece cubo y deshabilita i. Cuenta hasta 5, aparece cubo y luego permita volver a presionar I

    private IEnumerator HideCube()
    {
        transform.GetComponentInParent<Renderer>().enabled = false;
        _iEnabled = false;
        yield return _waitForSeconds;
        transform.GetComponentInParent<Renderer>().enabled = true;
        _iEnabled = true;
    }

    private IEnumerator ChangeColor()
    {
        while(_cambiarColor)
        {
            yield return _waitForSeconds;
            _renderer.material.color = new Color(Random.value,Random.value,Random.value);
        }

    }

}
