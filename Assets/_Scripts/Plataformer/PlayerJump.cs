using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float jumpforce;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Método para saltar
    public void Jump()
    {   
        if(Mathf.Abs(_rb.velocity.y) < 0.01) 
            _rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
