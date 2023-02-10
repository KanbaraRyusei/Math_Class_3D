using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float _deg;

    [SerializeField]
    private float _r = 5f;

    private void FixedUpdate()
    {
        transform.position = new Vector3(_r * Mathf.Cos(_deg), _r * Mathf.Sin(_deg), 0.5f);
        _deg += 2f * Mathf.PI / 360f;
    }
}
