using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //private Rigidbody2D _rigidBody;
    private Rigidbody2D _bodyRigidBody;


    // Use this for initialization
    void Start()
    {
        _bodyRigidBody = GameObject.Find("TankBody").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_bodyRigidBody.transform.position.x, _bodyRigidBody.transform.position.y, transform.position.z);
    }
}
