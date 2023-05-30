using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigonometricFunctionMove : MonoBehaviour
{
    [SerializeField]
    private Material[] _materialArray = new Material[2];

    [SerializeField]
    private float _theta;

    [SerializeField]
    private float _sin;

    [SerializeField]
    private float _cos;

    [SerializeField]
    private float _tan;

    [SerializeField]
    private float _num;

    [SerializeField]
    private MoveType _type;

    private MeshRenderer _meshRendererCache = null;

    private void Start()
    {
        _meshRendererCache = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        switch (_type)
        {
            case MoveType.Sin:
                SinMove();
                break;
            case MoveType.Cos:
                CosMove();
                break;
            case MoveType.Tan:
                TanMove();
                break;
            case MoveType.DoubleSin:
                DoubleSinMove();
                break;
            case MoveType.DoubleCos:
                DoubleCosMove();
                break;
            case MoveType.DoubleTan:
                DoubleTanMove();
                break;
        }

        _theta += 2f * Mathf.PI / 360f;
    }

    private void SinMove()
    {
        _sin = Mathf.Sin(_theta);

        transform.position = new Vector3(_theta - 10f, _sin, 0.5f);

        if (_sin > 0f)
        {
            _meshRendererCache.material = _materialArray[1];
        }
        else
        {
            _meshRendererCache.material = _materialArray[0];
        }
    }

    private void CosMove()
    {
        _cos = Mathf.Cos(_theta);

        transform.position = new Vector3(_theta - 10f, _cos, 0.5f);

        if (_cos > 0f)
        {
            _meshRendererCache.material = _materialArray[1];
        }
        else
        {
            _meshRendererCache.material = _materialArray[0];
        }
    }

    private void TanMove()
    {
        _tan = Mathf.Tan(_theta);

        transform.position = new Vector3(_theta - 10f, _tan, 0.5f);

        if (_tan > 0f)
        {
            _meshRendererCache.material = _materialArray[1];
        }
        else
        {
            _meshRendererCache.material = _materialArray[0];
        }
    }

    private void DoubleSinMove()
    {
        _sin = Mathf.Sin(_theta);

        transform.position = new Vector3(_theta - 10f, Mathf.Sin(_num * _sin), 0.5f);

        if (_sin > 0f)
        {
            _meshRendererCache.material = _materialArray[1];
        }
        else
        {
            _meshRendererCache.material = _materialArray[0];
        }
    }

    private void DoubleCosMove()
    {
        _cos = Mathf.Cos(_theta);

        transform.position = new Vector3(_theta - 10f, Mathf.Cos(_num * _cos), 0.5f);

        if (_cos > 0f)
        {
            _meshRendererCache.material = _materialArray[1];
        }
        else
        {
            _meshRendererCache.material = _materialArray[0];
        }
    }

    private void DoubleTanMove()
    {
        _tan = Mathf.Tan(_theta);

        transform.position = new Vector3(_theta - 10f, Mathf.Tan(_num * Mathf.Tan(_theta)), 0.5f);

        if (_tan > 0f)
        {
            _meshRendererCache.material = _materialArray[1];
        }
        else
        {
            _meshRendererCache.material = _materialArray[0];
        }
    }
}

public enum MoveType
{
    Sin,
    Cos,
    Tan,
    DoubleSin,
    DoubleCos,
    DoubleTan
}
