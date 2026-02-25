using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorandPos : MonoBehaviour

{
    //Creacion de variables
    private SpriteRenderer _renderer;
    public GameObject triangle;
    
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
    }
}
