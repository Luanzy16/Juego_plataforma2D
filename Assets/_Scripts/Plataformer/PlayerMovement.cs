using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private NewInput _newInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.score = 0;
        _newInput = GetComponent<NewInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        transform.Translate(Vector3.right * _newInput.inputX * speed * Time.deltaTime);
    }
}
