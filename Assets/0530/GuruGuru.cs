using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuruGuru : MonoBehaviour
{
    [SerializeField]
    private float _theta;

    [SerializeField]
    private float _phi;

    [SerializeField]
    private float _r;

    private void FixedUpdate()
    {
        float x = _r * Mathf.Sin(_theta) * Mathf.Cos(_phi);
        float y = _r * Mathf.Cos(_theta);
        float z = _r * Mathf.Sin(_theta) * Mathf.Sin(_phi);

        transform.position = new Vector3(x, y, z);

        _theta += 0.05f * (2f * Mathf.PI / 360f);
        _phi += 3f * (2f * Mathf.PI / 360f);
    }
}
