using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField]
    private float _radius = 1.5f;

    [SerializeField]
    private float _power = 10f;

    [SerializeField]
    private Rigidbody _ball;

    private void FixedUpdate()
    {
        float x = _ball.transform.position.x - this.transform.position.x;
        float z = _ball.transform.position.z - this.transform.position.z;

        if(x * x + z * z < _radius * _radius)
        {
            _ball.AddForce((_ball.transform.position - transform.position).normalized * _power, ForceMode.Impulse);
        }
    }
}
