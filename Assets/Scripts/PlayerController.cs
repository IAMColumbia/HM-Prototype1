using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;

    private float _horizontalInput;
    private float _forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Set up player input
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on player input
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * _forwardInput);

        // Rotate the vehicle based on player input
        transform.Rotate(Vector3.up, Time.deltaTime * _turnSpeed * _horizontalInput);
        
    }
}
