using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private Rigidbody2D _playerRigidBody;
    private float _speed = 0.05f;

    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _playerRigidBody = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            var xSpeed = Mathf.Cos((_playerRigidBody.rotation - 90) / 180 * (Mathf.PI)) * _speed;
            var ySpeed = Mathf.Sin((_playerRigidBody.rotation - 90) / 180 * (Mathf.PI)) * _speed;

            _rigidBody.position = new Vector2(_rigidBody.position.x - xSpeed, _rigidBody.position.y - ySpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            var xSpeed = Mathf.Cos((_playerRigidBody.rotation - 90) / 180 * (Mathf.PI)) * _speed;
            var ySpeed = Mathf.Sin((_playerRigidBody.rotation - 90) / 180 * (Mathf.PI)) * _speed;

            _rigidBody.position = new Vector2(_rigidBody.position.x + xSpeed, _rigidBody.position.y + ySpeed);
        }
    }
}
