using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    [SerializeField]
    private float _radius = 1f;

    [SerializeField]
    private Rigidbody _ball;

    private void FixedUpdate()
    {
        float x = _ball.transform.position.x - this.transform.position.x;
        float z = _ball.transform.position.z - this.transform.position.z;

        if (x * x + z * z < _radius * _radius)
        {
            _ball.transform.position = (_ball.transform.position).normalized * _radius;
        }
    }
}
