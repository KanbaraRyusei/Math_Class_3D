using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    private Material[] _materialArray = new Material[2];

    [SerializeField]
    private float _rad;

    [SerializeField]
    private float _sin;

    private MeshRenderer _meshRendererCache = null;

    private void Start()
    {
        _meshRendererCache = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        _sin = Mathf.Sin(_rad);

        if(0.7f < _sin && _sin < 0.9f)
        {
            _meshRendererCache.material = _materialArray[1];
        }
        else
        {
            _meshRendererCache.material = _materialArray[0];
        }

        _rad += 2f * (2f * Mathf.PI / 360f);
    }
}
