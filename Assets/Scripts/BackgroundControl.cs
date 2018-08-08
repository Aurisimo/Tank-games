using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private float _speed = 0.01f;

    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidBody.position = new Vector2(_rigidBody.position.x - _speed, _rigidBody.position.y);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidBody.position = new Vector2(_rigidBody.position.x + _speed, _rigidBody.position.y);
        }
    }
}
