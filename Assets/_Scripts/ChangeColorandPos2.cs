using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorandPos2 : MonoBehaviour
{
    //Creacion de variables 
    private SpriteRenderer _renderer;
    public GameObject triangle;

    public float posicionActualX;
    public float posicionActualY;
    public float posicionActualZ;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        ChangeColor();
        ChangePosition();
    }

    // Funcion para cambiar el color del sprite
    public void ChangeColor()
    {
        _renderer.color = Color.blue;
    }

    // Funcion para cambiar la posicion del sprite
    public void ChangePosition()
    {
        transform.position = triangle.transform.position;
        posicionActualX = transform.position.x;
        posicionActualY = transform.position.y;
        posicionActualZ = transform.position.z;

        Debug.Log(string.Format("La poscion del ciruclo es ({0} , {1}, {2} ) y es de color azul", posicionActualX, posicionActualY, posicionActualZ));
    }
}
