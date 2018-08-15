using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBodyControl : MonoBehaviour
{

    private Rigidbody2D _rigidBody;
    private float _rotationSpeed = 1f;
    private float _movingSpeed = 0.05f;

    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidBody.rotation += _rotationSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidBody.rotation -= _rotationSpeed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            float xSpeed = GetXSpeed();
            float ySpeed = GetYSpeed();

            _rigidBody.position = new Vector2(_rigidBody.position.x - xSpeed, _rigidBody.position.y - ySpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            float xSpeed = GetXSpeed();
            float ySpeed = GetYSpeed();

            _rigidBody.position = new Vector2(_rigidBody.position.x + xSpeed, _rigidBody.position.y + ySpeed);
        }
    }

    private float GetYSpeed()
    {
        return Mathf.Sin((_rigidBody.rotation - 90) / 180 * (Mathf.PI)) * _movingSpeed;
    }

    private float GetXSpeed()
    {
        return Mathf.Cos((_rigidBody.rotation - 90) / 180 * (Mathf.PI)) * _movingSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _movingSpeed = 2f;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        _movingSpeed = 2f;
        if (collision.gameObject.name == "Road1 (1)")
        {            
            Debug.Log("Faster Road");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        _movingSpeed = 0.05f;
        if (collision.gameObject.name == "Road1 (1)")
        {            
            Debug.Log("Slower Road");
        }
    }
}
