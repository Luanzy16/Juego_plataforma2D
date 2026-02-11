using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Creacion de variables 
    [Header("Numbers")]

    public int a; 
    public int b;
    private int _result;

    // Start is called before the first frame update
    void Start()
    {
       Sum();
    }

    // Funcion que realiza la suma de dos numeros enteros
    public void Sum()
    {
        _result = a + b;
        Debug.Log("El resultado es: " + _result);
        Debug.Log(string.Format("El resultado de sumar {0} y {1} es: {2}", a, b, _result));
    }
}
