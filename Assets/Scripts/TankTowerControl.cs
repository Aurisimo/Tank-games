using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTowerControl : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private Rigidbody2D _bodyRigidbody;
    private readonly float _rotationSpeed = 2;
    readonly Projectile projectile;

    // Use this for initialization
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _bodyRigidbody = GameObject.Find("TankBody").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _rigidBody.rotation += _rotationSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rigidBody.rotation -= _rotationSpeed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
           // var clone = Instantiate(projectile, transform.position, transform.rotation);
        }

        _rigidBody.position = new Vector2(_bodyRigidbody.position.x, _bodyRigidbody.position.y);
    }
}
