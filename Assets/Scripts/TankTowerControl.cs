using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTowerControl : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private float _speed = 2;

    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _rigidBody.rotation += _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rigidBody.rotation -= _speed;
        }

    }
}
