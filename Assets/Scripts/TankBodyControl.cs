using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBodyControl : MonoBehaviour
{

    private Rigidbody2D _rigidbody;
    private float _speed = 1f;

    // Use this for initialization
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.rotation += _speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.rotation -= _speed;
        }
    }
}
