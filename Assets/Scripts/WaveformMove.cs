using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveformMove : MonoBehaviour
{
    [SerializeField]
    private int _wave = 5;

    [SerializeField]
    private float _deg;

    [SerializeField]
    private float _r = 5f;

    [SerializeField]
    private float _length = 5f;

    [SerializeField]
    private float _value = 1f;

    private void FixedUpdate()
    {
        Waveform();
    }

    private void Waveform()
    {
        var x = _r * Mathf.Cos(_deg);
        var y = _r * Mathf.Sin(_deg);
        var z = 0.5f;
        transform.position = new Vector3(x, y, z);
        _deg += 2f * Mathf.PI / 360f;
        _r = Mathf.Sin(_deg * _wave) * _value + _length;
    }
}
