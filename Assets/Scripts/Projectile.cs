using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	private const float _movingSpeed = 0.4f;
	private float _xSpeed;  
	private float _ySpeed;
	private Rigidbody2D _rigidbody;

	// Use this for initialization
	void Start () 
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		_xSpeed = GetXSpeed();  
		_ySpeed = GetYSpeed();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector2(transform.position.x - _xSpeed, transform.position.y - _ySpeed);
	}

	private float GetYSpeed()
    {
        return Mathf.Sin((_rigidbody.rotation - 90) / 180 * (Mathf.PI)) * _movingSpeed;
    }

    private float GetXSpeed()
    {
        return Mathf.Cos((_rigidbody.rotation - 90) / 180 * (Mathf.PI)) * _movingSpeed;
    }
}
