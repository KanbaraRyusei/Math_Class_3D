using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHitArea : MonoBehaviour
{
    [SerializeField]
    private int _radius = 6;

    [SerializeField]
    private float _power = 15f;

    [SerializeField]
    private bool _isFlip;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (transform.position.x * transform.position.x + transform.position.z * transform.position.z < _radius * _radius)
        {
            if (_isFlip)
            {
                // ¨‚¢‚ð‚Â‚¯‚Ä‚Í‚¶‚­
                _rb.AddForce((transform.position).normalized * _power, ForceMode.Impulse);
                return;
            }

            // ‰~Žüã‚É‰ˆ‚Á‚Ä“®‚­
            transform.position = (transform.position).normalized * _radius;
        }
    }
}
